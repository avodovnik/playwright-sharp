using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using PlaywrightSharp.Helpers;
using PlaywrightSharp.Input;
using PlaywrightSharp.Transport.Converters;

namespace PlaywrightSharp.Transport.Channels
{
    internal class FrameChannel : Channel<Frame>
    {
        public FrameChannel(string guid, Connection connection, Frame owner) : base(guid, connection, owner)
        {
        }

        internal event EventHandler<FrameNavigatedEventArgs> Navigated;

        internal event EventHandler<FrameChannelLoadStateEventArgs> LoadState;

        internal override void OnMessage(string method, JsonElement? serverParams)
        {
            switch (method)
            {
                case "navigated":
                    var e = serverParams?.ToObject<FrameNavigatedEventArgs>(Connection.GetDefaultJsonSerializerOptions());

                    if (serverParams.Value.TryGetProperty("newDocument", out var documentElement))
                    {
                        e.NewDocument = documentElement.ToObject<NavigateDocument>(Connection.GetDefaultJsonSerializerOptions());
                    }

                    Navigated?.Invoke(this, e);
                    break;
                case "loadstate":
                    LoadState?.Invoke(
                        this,
                        serverParams?.ToObject<FrameChannelLoadStateEventArgs>(Connection.GetDefaultJsonSerializerOptions()));
                    break;
            }
        }

        internal Task<ResponseChannel> GoToAsync(string url, int? timeout, LifecycleEvent? waitUntil, string referer, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["url"] = url,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (waitUntil != null)
            {
                args["waitUntil"] = waitUntil;
            }

            if (waitUntil != null)
            {
                args["waitUntil"] = waitUntil;
            }

            if (referer != null)
            {
                args["referer"] = referer;
            }

            return Connection.SendMessageToServerAsync<ResponseChannel>(Guid, "goto", args);
        }

        internal Task<JSHandleChannel> EvaluateExpressionHandleAsync(
            string script,
            bool isFunction,
            object arg,
            bool isPage,
            bool serializeArgument = false)
        {
            JsonSerializerOptions serializerOptions;

            if (serializeArgument)
            {
                serializerOptions = JsonExtensions.GetNewDefaultSerializerOptions(false);
                arg = new EvaluateArgument
                {
                    Handles = new List<EvaluateArgumentGuidElement>(),
                    Value = arg,
                };
                serializerOptions.Converters.Add(new EvaluateArgumentConverter());
            }
            else
            {
                serializerOptions = Connection.GetDefaultJsonSerializerOptions(false);
            }

            return Connection.SendMessageToServerAsync<JSHandleChannel>(
                Guid,
                "evaluateExpressionHandle",
                new Dictionary<string, object>
                {
                    ["expression"] = script,
                    ["isFunction"] = isFunction,
                    ["arg"] = arg,
                    ["isPage"] = isPage,
                },
                serializerOptions: serializerOptions);
        }

        internal Task<JSHandleChannel> WaitForFunctionAsync(
            string expression,
            bool isFunction,
            object arg,
            bool isPage,
            int? timeout,
            int? polling,
            bool serializeArgument = false)
        {
            JsonSerializerOptions serializerOptions;

            if (serializeArgument)
            {
                serializerOptions = JsonExtensions.GetNewDefaultSerializerOptions(false);
                arg = new EvaluateArgument
                {
                    Handles = new List<EvaluateArgumentGuidElement>(),
                    Value = arg,
                };
                serializerOptions.Converters.Add(new EvaluateArgumentConverter());
            }
            else
            {
                serializerOptions = Connection.GetDefaultJsonSerializerOptions(false);
            }

            var args = new Dictionary<string, object>
            {
                ["expression"] = expression,
                ["isFunction"] = isFunction,
                ["arg"] = arg,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (polling != null)
            {
                args["pollingInterval"] = polling;
            }

            return Connection.SendMessageToServerAsync<JSHandleChannel>(
                Guid,
                "waitForFunction",
                args,
                serializerOptions: serializerOptions);
        }

        internal Task<JsonElement?> EvaluateExpressionAsync(
            string script,
            bool isFunction,
            object arg,
            bool isPage,
            bool serializeArgument = false)
        {
            JsonSerializerOptions serializerOptions;

            if (serializeArgument)
            {
                serializerOptions = JsonExtensions.GetNewDefaultSerializerOptions(false);
                arg = new EvaluateArgument
                {
                    Handles = new List<EvaluateArgumentGuidElement>(),
                    Value = arg,
                };
                serializerOptions.Converters.Add(new EvaluateArgumentConverter());
            }
            else
            {
                serializerOptions = Connection.GetDefaultJsonSerializerOptions(false);
            }

            return Connection.SendMessageToServerAsync<JsonElement?>(
                Guid,
                "evaluateExpression",
                new Dictionary<string, object>
                {
                    ["expression"] = script,
                    ["isFunction"] = isFunction,
                    ["arg"] = arg,
                    ["isPage"] = isPage,
                },
                serializerOptions: serializerOptions);
        }

        internal Task<JSHandleChannel> EvalOnSelectorAsync(string selector, string script, bool isFunction, object arg, bool isPage)
            => Connection.SendMessageToServerAsync<JSHandleChannel>(
                Guid,
                "evalOnSelector",
                new Dictionary<string, object>
                {
                    ["selector"] = selector,
                    ["expression"] = script,
                    ["isFunction"] = isFunction,
                    ["arg"] = arg,
                    ["isPage"] = isPage,
                });

        internal Task<JsonElement?> EvalOnSelectorAsync(string selector, string script, bool isFunction, EvaluateArgument arg, bool isPage)
            => Connection.SendMessageToServerAsync<JsonElement?>(
                Guid,
                "evalOnSelector",
                new Dictionary<string, object>
                {
                    ["selector"] = selector,
                    ["expression"] = script,
                    ["isFunction"] = isFunction,
                    ["arg"] = arg,
                    ["isPage"] = isPage,
                });

        internal Task<JSHandleChannel> EvalOnSelectorAllAsync(string selector, string script, bool isFunction, object arg, bool isPage)
            => Connection.SendMessageToServerAsync<JSHandleChannel>(
                Guid,
                "evalOnSelectorAll",
                new Dictionary<string, object>
                {
                    ["selector"] = selector,
                    ["expression"] = script,
                    ["isFunction"] = isFunction,
                    ["arg"] = arg,
                    ["isPage"] = isPage,
                });

        internal Task<JsonElement?> EvalOnSelectorAllAsync(string selector, string script, bool isFunction, EvaluateArgument arg, bool isPage)
            => Connection.SendMessageToServerAsync<JsonElement?>(
                Guid,
                "evalOnSelectorAll",
                new Dictionary<string, object>
                {
                    ["selector"] = selector,
                    ["expression"] = script,
                    ["isFunction"] = isFunction,
                    ["arg"] = arg,
                    ["isPage"] = isPage,
                });

        internal Task<ElementHandleChannel> GetFrameElementAsync() => Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "frameElement", null);

        internal async Task<string> GetTitleAsync()
            => (await Connection.SendMessageToServerAsync(Guid, "title", null).ConfigureAwait(false))?.GetProperty("value").ToString();

        internal Task<ElementHandleChannel> WaitForSelectorAsync(string selector, WaitForState? state, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (state != null)
            {
                args["state"] = state;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(
                Guid,
                "waitForSelector",
                args);
        }

        internal Task<ElementHandleChannel> AddScriptTagAsync(string url, string path, string content, string type, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["isPage"] = isPage,
            };

            if (!string.IsNullOrEmpty(url))
            {
                args["url"] = url;
            }

            if (!string.IsNullOrEmpty(path))
            {
                args["path"] = path;
            }

            if (!string.IsNullOrEmpty(content))
            {
                args["content"] = content;
            }

            if (!string.IsNullOrEmpty(type))
            {
                args["type"] = type;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "addScriptTag", args);
        }

        internal Task<ElementHandleChannel> AddStyleTagAsync(string url, string path, string content, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["isPage"] = isPage,
            };

            if (!string.IsNullOrEmpty(url))
            {
                args["url"] = url;
            }

            if (!string.IsNullOrEmpty(path))
            {
                args["path"] = path;
            }

            if (!string.IsNullOrEmpty(content))
            {
                args["content"] = content;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "addStyleTag", args);
        }

        internal Task<ResponseChannel> WaitForNavigationAsync(LifecycleEvent? waitUntil, string url, int? timeout, bool isPage)
        {
            var param = new Dictionary<string, object>
            {
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                param["timeout"] = timeout;
            }

            if (url != null)
            {
                param["url"] = url;
            }

            if (waitUntil != null)
            {
                param["waitUntil"] = waitUntil;
            }

            return Connection.SendMessageToServerAsync<ResponseChannel>(Guid, "waitForNavigation", param);
        }

        internal Task WaitForLoadStateAsync(LifecycleEvent? state, int? timeout, bool isPage)
        {
            var param = new Dictionary<string, object>
            {
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                param["timeout"] = timeout;
            }

            if (state != null)
            {
                param["state"] = state;
            }

            return Connection.SendMessageToServerAsync(
                Guid,
                "waitForLoadState",
                param);
        }

        internal Task SetContentAsync(string html, int? timeout, LifecycleEvent? waitUntil, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["html"] = html,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (waitUntil != null)
            {
                args["waitUntil"] = waitUntil;
            }

            return Connection.SendMessageToServerAsync(Guid, "setContent", args);
        }

        internal Task ClickAsync(
            string selector,
            int delay,
            MouseButton button,
            int clickCount,
            Modifier[] modifiers,
            Point? position,
            int? timeout,
            bool force,
            bool? noWaitAfter,
            bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["delay"] = delay,
                ["button"] = button,
                ["clickCount"] = clickCount,
                ["force"] = force,
                ["isPage"] = isPage,
            };

            if (modifiers != null)
            {
                args["modifiers"] = modifiers?.Select(m => m.ToValueString());
            }

            if (position != null)
            {
                args["position"] = position;
            }

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "click", args);
        }

        internal Task DblClickAsync(
            string selector,
            int delay,
            MouseButton button,
            Modifier[] modifiers,
            Point? position,
            int? timeout,
            bool force,
            bool? noWaitAfter,
            bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["delay"] = delay,
                ["button"] = button,
                ["force"] = force,
                ["isPage"] = isPage,
            };

            if (modifiers != null)
            {
                args["modifiers"] = modifiers?.Select(m => m.ToValueString());
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (position != null)
            {
                args["position"] = position;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "dblclick", args);
        }

        internal Task<ElementHandleChannel> QuerySelectorAsync(string selector, bool isPage)
            => Connection.SendMessageToServerAsync<ElementHandleChannel>(
                Guid,
                "querySelector",
                new Dictionary<string, object>
                {
                    ["selector"] = selector,
                    ["isPage"] = isPage,
                });

        internal Task<ChannelBase[]> QuerySelectorAllAsync(string selector, bool isPage)
            => Connection.SendMessageToServerAsync<ChannelBase[]>(
                Guid,
                "querySelectorAll",
                new Dictionary<string, object>
                {
                    ["selector"] = selector,
                    ["isPage"] = isPage,
                });

        internal Task FillAsync(string selector, string value, int? timeout, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["value"] = value,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            return Connection.SendMessageToServerAsync(Guid, "fill", args);
        }

        internal Task CheckAsync(string selector, int? timeout, bool force, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["force"] = force,
                ["isPage"] = isPage,
            };

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "check", args);
        }

        internal Task UncheckAsync(string selector, int? timeout, bool force, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["force"] = force,
                ["isPage"] = isPage,
            };

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "uncheck", args);
        }

        internal Task DispatchEventAsync(string selector, string type, object eventInit, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["type"] = type,
                ["eventInit"] = eventInit,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync(Guid, "dispatchEvent", args);
        }

        internal Task HoverAsync(string selector, Point? position, Modifier[] modifiers, bool force, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["force"] = force,
                ["isPage"] = isPage,
            };

            if (modifiers != null)
            {
                args["modifiers"] = modifiers?.Select(m => m.ToValueString());
            }

            if (position != null)
            {
                args["position"] = position;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync(Guid, "hover", args);
        }

        internal Task<string[]> PressAsync(string selector, string text, int delay, int? timeout, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["key"] = text,
                ["delay"] = delay,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            return Connection.SendMessageToServerAsync<string[]>(Guid, "press", args);
        }

        internal async Task<string[]> SelectOptionAsync(string selector, object values, int? timeout, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["isPage"] = isPage,
            };

            if (values != null)
            {
                if (values is IElementHandle[])
                {
                    args["elements"] = values;
                }
                else
                {
                    args["options"] = values;
                }
            }

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return (await Connection.SendMessageToServerAsync(Guid, "selectOption", args).ConfigureAwait(false))?.GetProperty("values").ToObject<string[]>();
        }

        internal async Task<string> GetAttributeAsync(string selector, string name, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["name"] = name,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return (await Connection.SendMessageToServerAsync(Guid, "getAttribute", args).ConfigureAwait(false))?.GetProperty("value").ToString();
        }

        internal async Task<string> GetInnerHtmlAsync(string selector, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return (await Connection.SendMessageToServerAsync(Guid, "innerHTML", args).ConfigureAwait(false))?.GetProperty("value").ToString();
        }

        internal Task TypeAsync(string selector, string text, int? delay, int? timeout, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["text"] = text,
                ["delay"] = delay,
                ["isPage"] = isPage,
            };

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync(Guid, "type", args);
        }

        internal async Task<string> GetContentAsync(bool isPage)
            => (await Connection.SendMessageToServerAsync(
                Guid,
                "content",
                new Dictionary<string, object>
                {
                    ["isPage"] = isPage,
                }).ConfigureAwait(false))?.GetProperty("value").ToString();

        internal Task FocusAsync(string selector, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync(Guid, "focus", args);
        }

        internal async Task<string> GetInnerTextAsync(string selector, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return (await Connection.SendMessageToServerAsync(Guid, "innerText", args).ConfigureAwait(false))?.GetProperty("value").ToString();
        }

        internal Task SetInputFilesAsync(string selector, FilePayload[] files, int? timeout, bool? noWaitAfter, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["files"] = files,
                ["isPage"] = isPage,
            };

            if (noWaitAfter != null)
            {
                args["noWaitAfter"] = noWaitAfter;
            }

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return Connection.SendMessageToServerAsync<string>(Guid, "setInputFiles", args);
        }

        internal async Task<string> GetTextContentAsync(string selector, int? timeout, bool isPage)
        {
            var args = new Dictionary<string, object>
            {
                ["selector"] = selector,
                ["isPage"] = isPage,
            };

            if (timeout != null)
            {
                args["timeout"] = timeout;
            }

            return (await Connection.SendMessageToServerAsync(Guid, "textContent", args).ConfigureAwait(false))?.GetProperty("value").ToString();
        }

        internal Task TapAsync(string selector, FrameTapOptions options)
        {
            var args = new Dictionary<string, object>
            {
                ["force"] = options.Force,
                ["noWaitAfter"] = options.NoWaitAfter,
            };

            if (options.Modifiers != null)
            {
                args["modifiers"] = options.Modifiers.Select(m => m.ToValueString());
            }

            if (options.Timeout != 0)
            {
                args["timeout"] = options?.Timeout;
            }

            if (options.Position.HasValue)
            {
                args["position"] = new Dictionary<string, object>
                {
                    ["x"] = options.Position.Value.x,
                    ["y"] = options.Position.Value.y,
                };
            }

            return Connection.SendMessageToServer(Guid, "tap", args);
        }
    }
}
