using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using PlaywrightSharp.Helpers;
using PlaywrightSharp.Transport;
using PlaywrightSharp.Transport.Channels;
using PlaywrightSharp.Transport.Protocol;

namespace PlaywrightSharp
{
    internal partial class BindingCall : ChannelOwnerBase, IChannelOwner<BindingCall>
    {
        internal async Task CallAsync(Delegate binding)
        {
            try
            {
                const string taskResultPropertyName = "Result";
                var methodParams = binding.Method.GetParameters().Select(parameter => parameter.ParameterType).Skip(1).ToArray();
                var args = new List<object>
                {
                    new BindingSource
                    {
                        Context = _initializer?.Frame?.Page?.Context,
                        Page = _initializer?.Frame?.Page,
                        Frame = _initializer?.Frame,
                    },
                };

                if (methodParams.Length == 1 && methodParams[0] == typeof(IJSHandle))
                {
                    args.Add(_initializer.Handle.Object);
                }
                else
                {
                    for (int i = 0; i < methodParams.Length; i++)
                    {
                        args.Add(ScriptsHelper.ParseEvaluateResult(_initializer.Args[i], methodParams[i]));
                    }
                }

                object result = binding.DynamicInvoke(args.ToArray());

                if (result is Task taskResult)
                {
                    await taskResult.ConfigureAwait(false);

                    if (taskResult.GetType().IsGenericType)
                    {
                        // the task is already awaited and therefore the call to property Result will not deadlock
                        result = taskResult.GetType().GetProperty(taskResultPropertyName).GetValue(taskResult);
                    }
                }

                await _channel.ResolveAsync(result).ConfigureAwait(false);
            }
            catch (TargetInvocationException ex)
            {
                await _channel.RejectAsync(ex.InnerException).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await _channel.RejectAsync(ex).ConfigureAwait(false);
            }
        }
    }
}
