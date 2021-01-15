
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class PageChannel : Channel<Page>
    {
        public PageChannel(string guid, Connection connection, Page owner) : base(guid, connection, owner)
        {
        }

     public async Task SetDefaultNavigationTimeoutNoReplyAsync(double Timeout)
     {
     	var args = new Dictionary<string, object> ();
     	args["timeout"] = Timeout;
     	await Connection.SendMessageToServerAsync(Guid, "setDefaultNavigationTimeoutNoReply", args);
     }

     public async Task SetDefaultTimeoutNoReplyAsync(double Timeout)
     {
     	var args = new Dictionary<string, object> ();
     	args["timeout"] = Timeout;
     	await Connection.SendMessageToServerAsync(Guid, "setDefaultTimeoutNoReply", args);
     }

     public async Task SetFileChooserInterceptedNoReplyAsync(bool Intercepted)
     {
     	var args = new Dictionary<string, object> ();
     	args["intercepted"] = Intercepted;
     	await Connection.SendMessageToServerAsync(Guid, "setFileChooserInterceptedNoReply", args);
     }

     public async Task AddInitScriptAsync(string Source)
     {
     	var args = new Dictionary<string, object> ();

     	if (Source != null)
     	{
     		args["source"] = Source;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "addInitScript", args);
     }

     public async Task CloseAsync(bool? RunBeforeUnload)
     {
     	var args = new Dictionary<string, object> ();

     	if (RunBeforeUnload != null)
     	{
     		args["runBeforeUnload"] = RunBeforeUnload;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "close", args);
     }

     public async Task EmulateMediaAsync(PageMediaEnum? Media, PageColorSchemeEnum? ColorScheme)
     {
     	var args = new Dictionary<string, object> ();

     	if (Media != null)
     	{
     		args["media"] = Media;
     	}

     	if (ColorScheme != null)
     	{
     		args["colorScheme"] = ColorScheme;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "emulateMedia", args);
     }

     public async Task ExposeBindingAsync(string Name, bool? NeedsHandle)
     {
     	var args = new Dictionary<string, object> ();

     	if (Name != null)
     	{
     		args["name"] = Name;
     	}

     	if (NeedsHandle != null)
     	{
     		args["needsHandle"] = NeedsHandle;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "exposeBinding", args);
     }

     public async Task<Response?> GoBackAsync(double? Timeout, PageWaitUntilEnum? WaitUntil)
     {
     	var args = new Dictionary<string, object> ();

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (WaitUntil != null)
     	{
     		args["waitUntil"] = WaitUntil;
     	}
     	return await Connection.SendMessageToServerAsync<Response>(Guid, "goBack", args);
     }

     public async Task<Response?> GoForwardAsync(double? Timeout, PageWaitUntilEnum? WaitUntil)
     {
     	var args = new Dictionary<string, object> ();

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (WaitUntil != null)
     	{
     		args["waitUntil"] = WaitUntil;
     	}
     	return await Connection.SendMessageToServerAsync<Response>(Guid, "goForward", args);
     }

     public async Task<Page?> OpenerAsync()
     	=> await Connection.SendMessageToServerAsync<PageChannel>(Guid, "opener", null);

     public async Task<Response?> ReloadAsync(double? Timeout, PageWaitUntilEnum? WaitUntil)
     {
     	var args = new Dictionary<string, object> ();

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (WaitUntil != null)
     	{
     		args["waitUntil"] = WaitUntil;
     	}
     	return await Connection.SendMessageToServerAsync<Response>(Guid, "reload", args);
     }

     public async Task<string> ScreenshotAsync(double? Timeout, PageTypeEnum? Type, double? Quality, bool? OmitBackground, bool? FullPage, Clip Clip)
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

     	if (FullPage != null)
     	{
     		args["fullPage"] = FullPage;
     	}

     	if (Clip != null)
     	{
     		args["clip"] = Clip;
     	}
     	// TODO: Verify if we should do something special with this binary type.
     	return (await Connection.SendMessageToServerAsync(Guid, "screenshot", args).ConfigureAwait(false))?.GetProperty("binary").ToString();
     }

     public async Task SetExtraHTTPHeadersAsync(NameValue[] Headers)
     {
     	var args = new Dictionary<string, object> ();

     	if (Headers != null)
     	{
     		args["headers"] = Headers;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setExtraHTTPHeaders", args);
     }

     public async Task SetNetworkInterceptionEnabledAsync(bool Enabled)
     {
     	var args = new Dictionary<string, object> ();
     	args["enabled"] = Enabled;
     	await Connection.SendMessageToServerAsync(Guid, "setNetworkInterceptionEnabled", args);
     }

     public async Task SetViewportSizeAsync(ViewportSize ViewportSize)
     {
     	var args = new Dictionary<string, object> ();

     	if (ViewportSize != null)
     	{
     		args["viewportSize"] = ViewportSize;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setViewportSize", args);
     }

     public async Task KeyboardDownAsync(string Key)
     {
     	var args = new Dictionary<string, object> ();

     	if (Key != null)
     	{
     		args["key"] = Key;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "keyboardDown", args);
     }

     public async Task KeyboardUpAsync(string Key)
     {
     	var args = new Dictionary<string, object> ();

     	if (Key != null)
     	{
     		args["key"] = Key;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "keyboardUp", args);
     }

     public async Task KeyboardInsertTextAsync(string Text)
     {
     	var args = new Dictionary<string, object> ();

     	if (Text != null)
     	{
     		args["text"] = Text;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "keyboardInsertText", args);
     }

     public async Task KeyboardTypeAsync(string Text, double? Delay)
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
     	await Connection.SendMessageToServerAsync(Guid, "keyboardType", args);
     }

     public async Task KeyboardPressAsync(string Key, double? Delay)
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
     	await Connection.SendMessageToServerAsync(Guid, "keyboardPress", args);
     }

     public async Task MouseMoveAsync(double X, double Y, double? Steps)
     {
     	var args = new Dictionary<string, object> ();
     	args["x"] = X;
     	args["y"] = Y;

     	if (Steps != null)
     	{
     		args["steps"] = Steps;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "mouseMove", args);
     }

     public async Task MouseDownAsync(PageButtonEnum? Button, double? ClickCount)
     {
     	var args = new Dictionary<string, object> ();

     	if (Button != null)
     	{
     		args["button"] = Button;
     	}

     	if (ClickCount != null)
     	{
     		args["clickCount"] = ClickCount;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "mouseDown", args);
     }

     public async Task MouseUpAsync(PageButtonEnum? Button, double? ClickCount)
     {
     	var args = new Dictionary<string, object> ();

     	if (Button != null)
     	{
     		args["button"] = Button;
     	}

     	if (ClickCount != null)
     	{
     		args["clickCount"] = ClickCount;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "mouseUp", args);
     }

     public async Task MouseClickAsync(double X, double Y, double? Delay, PageButtonEnum? Button, double? ClickCount)
     {
     	var args = new Dictionary<string, object> ();
     	args["x"] = X;
     	args["y"] = Y;

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
     	await Connection.SendMessageToServerAsync(Guid, "mouseClick", args);
     }

     public async Task TouchscreenTapAsync(double X, double Y)
     {
     	var args = new Dictionary<string, object> ();
     	args["x"] = X;
     	args["y"] = Y;
     	await Connection.SendMessageToServerAsync(Guid, "touchscreenTap", args);
     }

     public async Task<AXNode?> AccessibilitySnapshotAsync(bool? InterestingOnly, ElementHandle? Root)
     {
     	var args = new Dictionary<string, object> ();

     	if (InterestingOnly != null)
     	{
     		args["interestingOnly"] = InterestingOnly;
     	}

     	if (Root != null)
     	{
     	}
     	return await Connection.SendMessageToServerAsync<AXNode>(Guid, "accessibilitySnapshot", args);
     }

     public async Task<string> PdfAsync(double? Scale, bool? DisplayHeaderFooter, string HeaderTemplate, string FooterTemplate, bool? PrintBackground, bool? Landscape, string PageRanges, string Format, string Width, string Height, bool? PreferCSSPageSize, Margin Margin)
     {
     	var args = new Dictionary<string, object> ();

     	if (Scale != null)
     	{
     		args["scale"] = Scale;
     	}

     	if (DisplayHeaderFooter != null)
     	{
     		args["displayHeaderFooter"] = DisplayHeaderFooter;
     	}

     	if (HeaderTemplate != null)
     	{
     		args["headerTemplate"] = HeaderTemplate;
     	}

     	if (FooterTemplate != null)
     	{
     		args["footerTemplate"] = FooterTemplate;
     	}

     	if (PrintBackground != null)
     	{
     		args["printBackground"] = PrintBackground;
     	}

     	if (Landscape != null)
     	{
     		args["landscape"] = Landscape;
     	}

     	if (PageRanges != null)
     	{
     		args["pageRanges"] = PageRanges;
     	}

     	if (Format != null)
     	{
     		args["format"] = Format;
     	}

     	if (Width != null)
     	{
     		args["width"] = Width;
     	}

     	if (Height != null)
     	{
     		args["height"] = Height;
     	}

     	if (PreferCSSPageSize != null)
     	{
     		args["preferCSSPageSize"] = PreferCSSPageSize;
     	}

     	if (Margin != null)
     	{
     		args["margin"] = Margin;
     	}
     	// TODO: Verify if we should do something special with this binary type.
     	return (await Connection.SendMessageToServerAsync(Guid, "pdf", args).ConfigureAwait(false))?.GetProperty("pdf").ToString();
     }

     public async Task CrStartJSCoverageAsync(bool? ResetOnNavigation, bool? ReportAnonymousScripts)
     {
     	var args = new Dictionary<string, object> ();

     	if (ResetOnNavigation != null)
     	{
     		args["resetOnNavigation"] = ResetOnNavigation;
     	}

     	if (ReportAnonymousScripts != null)
     	{
     		args["reportAnonymousScripts"] = ReportAnonymousScripts;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "crStartJSCoverage", args);
     }

     public async Task<EntriesItem[]> CrStopJSCoverageAsync()
     => throw new NotImplementedException();

     public async Task CrStartCSSCoverageAsync(bool? ResetOnNavigation)
     {
     	var args = new Dictionary<string, object> ();

     	if (ResetOnNavigation != null)
     	{
     		args["resetOnNavigation"] = ResetOnNavigation;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "crStartCSSCoverage", args);
     }

     public async Task<EntriesItem[]> CrStopCSSCoverageAsync()
     => throw new NotImplementedException();

     public async Task BringToFrontAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "bringToFront", null);
   }
}