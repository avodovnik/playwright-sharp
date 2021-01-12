
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class ElectronApplicationChannel : Channel<ElectronApplication>
    {
        public ElectronApplicationChannel(string guid, Connection connection, ElectronApplication owner) : base(guid, connection, owner)
        {
        }

     public async Task<Page> NewBrowserWindowAsync(SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();
     	return await Connection.SendMessageToServerAsync<Page>(Guid, "newBrowserWindow", args);
     }

     public async Task<SerializedValue> EvaluateExpressionAsync(string Expression, bool IsFunction, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;
     	return await Connection.SendMessageToServerAsync<SerializedValue>(Guid, "evaluateExpression", args);
     }

     public async Task<JSHandle> EvaluateExpressionHandleAsync(string Expression, bool IsFunction, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;
     	return await Connection.SendMessageToServerAsync<JSHandle>(Guid, "evaluateExpressionHandle", args);
     }

     public async Task CloseAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "close", null);
   }
}