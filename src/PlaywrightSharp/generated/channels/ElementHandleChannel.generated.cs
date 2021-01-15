
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class ElementHandleChannel : Channel<ElementHandle>
    {
        public ElementHandleChannel(string guid, Connection connection, ElementHandle owner) : base(guid, connection, owner)
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

     public async Task<Value> BoundingBoxAsync()
     => throw new NotImplementedException();

     public async Task CheckAsync(bool? Force, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task ClickAsync(bool? Force, bool? NoWaitAfter, ElementHandleModifiersItemEnum[] Modifiers, Position Position, double? Delay, ElementHandleButtonEnum? Button, double? ClickCount, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task<Frame?> ContentFrameAsync()
     	=> await Connection.SendMessageToServerAsync<FrameChannel>(Guid, "contentFrame", null);

     public async Task DblclickAsync(bool? Force, bool? NoWaitAfter, ElementHandleModifiersItemEnum[] Modifiers, Position Position, double? Delay, ElementHandleButtonEnum? Button, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task DispatchEventAsync(string Type, SerializedArgument EventInit)
     {
     	var args = new Dictionary<string, object> ();

     	if (Type != null)
     	{
     		args["type"] = Type;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "dispatchEvent", args);
     }

     public async Task FillAsync(string Value, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task FocusAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "focus", null);

     public async Task<string> GetAttributeAsync(string Name)
     {
     	var args = new Dictionary<string, object> ();

     	if (Name != null)
     	{
     		args["name"] = Name;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "getAttribute", args).ConfigureAwait(false))?.GetProperty("value").ToString();
     }

     public async Task HoverAsync(bool? Force, ElementHandleModifiersItemEnum[] Modifiers, Position Position, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task<string> InnerHTMLAsync()
     => throw new NotImplementedException();

     public async Task<string> InnerTextAsync()
     => throw new NotImplementedException();

     public async Task<Frame?> OwnerFrameAsync()
     	=> await Connection.SendMessageToServerAsync<FrameChannel>(Guid, "ownerFrame", null);

     public async Task PressAsync(string Key, double? Delay, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

     	if (Key != null)
     	{
     		args["key"] = Key;
     	}

     	if (Delay != null)
     	{
     		args["delay"] = Delay;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (NoWaitAfter != null)
     	{
     		args["noWaitAfter"] = NoWaitAfter;
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

     public async Task<string> ScreenshotAsync(double? Timeout, ElementHandleTypeEnum? Type, double? Quality, bool? OmitBackground)
     {
     	var args = new Dictionary<string, object> ();

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (Type != null)
     	{
     		args["type"] = Type;
     	}

     	if (Quality != null)
     	{
     		args["quality"] = Quality;
     	}

     	if (OmitBackground != null)
     	{
     		args["omitBackground"] = OmitBackground;
     	}
     	// TODO: Verify if we should do something special with this binary type.
     	return (await Connection.SendMessageToServerAsync(Guid, "screenshot", args).ConfigureAwait(false))?.GetProperty("binary").ToString();
     }

     public async Task ScrollIntoViewIfNeededAsync(double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "scrollIntoViewIfNeeded", args);
     }

     public async Task<string[]> SelectOptionAsync(ElementHandle[] Elements, OptionsItem[] Options, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task SelectTextAsync(double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "selectText", args);
     }

     public async Task SetInputFilesAsync(FilesItem[] Files, double? Timeout, bool? NoWaitAfter)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task TapAsync(bool? Force, bool? NoWaitAfter, ElementHandleModifiersItemEnum[] Modifiers, Position Position, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task<string> TextContentAsync()
     => throw new NotImplementedException();

     public async Task TypeAsync(string Text, double? Delay, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task UncheckAsync(bool? Force, bool? NoWaitAfter, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

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

     public async Task WaitForElementStateAsync(ElementHandleStateEnum State, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();
     	args["state"] = State;

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "waitForElementState", args);
     }

     public async Task<ElementHandle?> WaitForSelectorAsync(string Selector, double? Timeout, ElementHandleStateEnum? State)
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

     public async Task<string> CreateSelectorForTestAsync(string Name)
     {
     	var args = new Dictionary<string, object> ();

     	if (Name != null)
     	{
     		args["name"] = Name;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "createSelectorForTest", args).ConfigureAwait(false))?.GetProperty("value").ToString();
     }
   }
}