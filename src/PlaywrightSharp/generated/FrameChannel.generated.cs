
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class FrameChannel : Channel<Frame>
    {
        public FrameChannel(string guid, Connection connection, Frame owner) : base(guid, connection, owner)
        {
        }

     public async Task<SerializedValue> EvalOnSelectorAsync(string Selector, string Expression, bool IsFunction, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;
     	return await Connection.SendMessageToServerAsync<SerializedValue>(Guid, "evalOnSelector", args);
     }

     public async Task<SerializedValue> EvalOnSelectorAllAsync(string Selector, string Expression, bool IsFunction, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;
     	return await Connection.SendMessageToServerAsync<SerializedValue>(Guid, "evalOnSelectorAll", args);
     }

     public async Task<ElementHandle> AddScriptTagAsync(string Url, string Content, string Type)
     {
     	var args = new Dictionary<string, object> ();

     	if (Url != null)
     	{
     		args["url"] = Url;
     	}

     	if (Content != null)
     	{
     		args["content"] = Content;
     	}

     	if (Type != null)
     	{
     		args["type"] = Type;
     	}
     	return await Connection.SendMessageToServerAsync<ElementHandle>(Guid, "addScriptTag", args);
     }

     public async Task<ElementHandle> AddStyleTagAsync(string Url, string Content)
     {
     	var args = new Dictionary<string, object> ();

     	if (Url != null)
     	{
     		args["url"] = Url;
     	}

     	if (Content != null)
     	{
     		args["content"] = Content;
     	}
     	return await Connection.SendMessageToServerAsync<ElementHandle>(Guid, "addStyleTag", args);
     }

     public async Task CheckAsync(string Selector, bool? Force, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Force != null)
     	{
     		args["force"] = Force;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "check", args);
     }

     public async Task ClickAsync(string Selector, bool? Force, bool? NoWaitAfter, FrameModifiersItemEnum[] Modifiers, Position Position, double? Delay, FrameButtonEnum? Button, double? ClickCount, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Force != null)
     	{
     		args["force"] = Force;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Modifiers != null)
     	{
     		args["modifiers"] = Modifiers;
     	}

     	if (Position != null)
     	{
     		args["position"] = Position;
     	}

     	if (Delay != null)
     	{
     		args["delay"] = Delay;
     	}

     	if (Button != null)
     	{
     		args["button"] = Button;
     	}

     	if (ClickCount != null)
     	{
     		args["clickCount"] = ClickCount;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "click", args);
     }

     public async Task<string> ContentAsync()
     => throw new NotImplementedException();

     public async Task DblclickAsync(string Selector, bool? Force, bool? NoWaitAfter, FrameModifiersItemEnum[] Modifiers, Position Position, double? Delay, FrameButtonEnum? Button, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Force != null)
     	{
     		args["force"] = Force;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Modifiers != null)
     	{
     		args["modifiers"] = Modifiers;
     	}

     	if (Position != null)
     	{
     		args["position"] = Position;
     	}

     	if (Delay != null)
     	{
     		args["delay"] = Delay;
     	}

     	if (Button != null)
     	{
     		args["button"] = Button;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "dblclick", args);
     }

     public async Task DispatchEventAsync(string Selector, string Type, SerializedArgument EventInit, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Type != null)
     	{
     		args["type"] = Type;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "dispatchEvent", args);
     }

     public async Task<SerializedValue> EvaluateExpressionAsync(string Expression, bool IsFunction, SerializedArgument Arg, FrameWorldEnum? World)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;

     	if (World != null)
     	{
     		args["world"] = World;
     	}
     	return await Connection.SendMessageToServerAsync<SerializedValue>(Guid, "evaluateExpression", args);
     }

     public async Task<JSHandle> EvaluateExpressionHandleAsync(string Expression, bool IsFunction, SerializedArgument Arg, FrameWorldEnum? World)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;

     	if (World != null)
     	{
     		args["world"] = World;
     	}
     	return await Connection.SendMessageToServerAsync<JSHandle>(Guid, "evaluateExpressionHandle", args);
     }

     public async Task FillAsync(string Selector, string Value, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Value != null)
     	{
     		args["value"] = Value;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "fill", args);
     }

     public async Task FocusAsync(string Selector, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "focus", args);
     }

     public async Task<ElementHandle> FrameElementAsync()
     	=> await Connection.SendMessageToServerAsync<ElementHandleChannel>(Guid, "frameElement", null);

     public async Task<string> GetAttributeAsync(string Selector, string Name, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Name != null)
     	{
     		args["name"] = Name;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "getAttribute", args).ConfigureAwait(false))?.GetProperty("value").ToString();
     }

     public async Task<Response?> GotoAsync(string Url, double? Timeout, FrameWaitUntilEnum? WaitUntil, string Referer)
     {
     	var args = new Dictionary<string, object> ();

     	if (Url != null)
     	{
     		args["url"] = Url;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (WaitUntil != null)
     	{
     		args["waitUntil"] = WaitUntil;
     	}

     	if (Referer != null)
     	{
     		args["referer"] = Referer;
     	}
     	return await Connection.SendMessageToServerAsync<Response>(Guid, "goto", args);
     }

     public async Task HoverAsync(string Selector, bool? Force, FrameModifiersItemEnum[] Modifiers, Position Position, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Force != null)
     	{
     		args["force"] = Force;
     	}

     	if (Modifiers != null)
     	{
     		args["modifiers"] = Modifiers;
     	}

     	if (Position != null)
     	{
     		args["position"] = Position;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "hover", args);
     }

     public async Task<string> InnerHTMLAsync(string Selector, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "innerHTML", args).ConfigureAwait(false))?.GetProperty("value").ToString();
     }

     public async Task<string> InnerTextAsync(string Selector, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "innerText", args).ConfigureAwait(false))?.GetProperty("value").ToString();
     }

     public async Task PressAsync(string Selector, string Key, double? Delay, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Key != null)
     	{
     		args["key"] = Key;
     	}

     	if (Delay != null)
     	{
     		args["delay"] = Delay;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "press", args);
     }

     public async Task<ElementHandle?> QuerySelectorAsync(string Selector)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}
     	return await Connection.SendMessageToServerAsync<ElementHandle>(Guid, "querySelector", args);
     }

     public async Task<ElementHandle[]> QuerySelectorAllAsync(string Selector)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}
     	return await Connection.SendMessageToServerAsync<ElementHandle[]>(Guid, "querySelectorAll", args);
     }

     public async Task<string[]> SelectOptionAsync(string Selector, ElementHandle[] Elements, OptionsItem[] Options, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Elements != null)
     	{
     		args["elements"] = Elements;
     	}

     	if (Options != null)
     	{
     		args["options"] = Options;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}
     	return await Connection.SendMessageToServerAsync<string[]>(Guid, "selectOption", args);
     }

     public async Task SetContentAsync(string Html, double? Timeout, FrameWaitUntilEnum? WaitUntil)
     {
     	var args = new Dictionary<string, object> ();

     	if (Html != null)
     	{
     		args["html"] = Html;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (WaitUntil != null)
     	{
     		args["waitUntil"] = WaitUntil;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setContent", args);
     }

     public async Task SetInputFilesAsync(string Selector, FilesItem[] Files, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Files != null)
     	{
     		args["files"] = Files;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setInputFiles", args);
     }

     public async Task TapAsync(string Selector, bool? Force, bool? NoWaitAfter, FrameModifiersItemEnum[] Modifiers, Position Position, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Force != null)
     	{
     		args["force"] = Force;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Modifiers != null)
     	{
     		args["modifiers"] = Modifiers;
     	}

     	if (Position != null)
     	{
     		args["position"] = Position;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "tap", args);
     }

     public async Task<string> TextContentAsync(string Selector, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "textContent", args).ConfigureAwait(false))?.GetProperty("value").ToString();
     }

     public async Task<string> TitleAsync()
     => throw new NotImplementedException();

     public async Task TypeAsync(string Selector, string Text, double? Delay, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Text != null)
     	{
     		args["text"] = Text;
     	}

     	if (Delay != null)
     	{
     		args["delay"] = Delay;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "type", args);
     }

     public async Task UncheckAsync(string Selector, bool? Force, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Force != null)
     	{
     		args["force"] = Force;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "uncheck", args);
     }

     public async Task<JSHandle> WaitForFunctionAsync(string Expression, bool IsFunction, SerializedArgument Arg, double? Timeout, double? PollingInterval)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (PollingInterval != null)
     	{
     		args["pollingInterval"] = PollingInterval;
     	}
     	return await Connection.SendMessageToServerAsync<JSHandle>(Guid, "waitForFunction", args);
     }

     public async Task<ElementHandle?> WaitForSelectorAsync(string Selector, double? Timeout, FrameStateEnum? State)
     {
     	var args = new Dictionary<string, object> ();

     	if (Selector != null)
     	{
     		args["selector"] = Selector;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (State != null)
     	{
     		args["state"] = State;
     	}
     	return await Connection.SendMessageToServerAsync<ElementHandle>(Guid, "waitForSelector", args);
     }

     public async Task<JSHandle> ExtendInjectedScriptAsync(string Source, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Source != null)
     	{
     		args["source"] = Source;
     	}
     	return await Connection.SendMessageToServerAsync<JSHandle>(Guid, "extendInjectedScript", args);
     }
   }
}