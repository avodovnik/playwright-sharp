
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class BrowserChannel : Channel<Browser>
    {
        public BrowserChannel(string guid, Connection connection, Browser owner) : base(guid, connection, owner)
        {
        }

     public async Task CloseAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "close", null);

     public async Task<BrowserContext> NewContextAsync(bool? NoDefaultViewport, Viewport Viewport, bool? IgnoreHTTPSErrors, bool? JavaScriptEnabled, bool? BypassCSP, string UserAgent, string Locale, string TimezoneId, Geolocation Geolocation, string[] Permissions, NameValue[] ExtraHTTPHeaders, bool? Offline, HttpCredentials HttpCredentials, double? DeviceScaleFactor, bool? IsMobile, bool? HasTouch, BrowserColorSchemeEnum? ColorScheme, bool? AcceptDownloads, string _traceResourcesPath, string _tracePath, RecordVideo RecordVideo, RecordHar RecordHar, Proxy Proxy, StorageState StorageState)
     {
     	var args = new Dictionary<string, object> ();

     	if (NoDefaultViewport != null)
     	{
     		args["noDefaultViewport"] = NoDefaultViewport;
     	}

     	if (Viewport != null)
     	{
     		args["viewport"] = Viewport;
     	}

     	if (IgnoreHTTPSErrors != null)
     	{
     		args["ignoreHTTPSErrors"] = IgnoreHTTPSErrors;
     	}

     	if (JavaScriptEnabled != null)
     	{
     		args["javaScriptEnabled"] = JavaScriptEnabled;
     	}

     	if (BypassCSP != null)
     	{
     		args["bypassCSP"] = BypassCSP;
     	}

     	if (UserAgent != null)
     	{
     		args["userAgent"] = UserAgent;
     	}

     	if (Locale != null)
     	{
     		args["locale"] = Locale;
     	}

     	if (TimezoneId != null)
     	{
     		args["timezoneId"] = TimezoneId;
     	}

     	if (Geolocation != null)
     	{
     		args["geolocation"] = Geolocation;
     	}

     	if (Permissions != null)
     	{
     		args["permissions"] = Permissions;
     	}

     	if (ExtraHTTPHeaders != null)
     	{
     		args["extraHTTPHeaders"] = ExtraHTTPHeaders;
     	}

     	if (Offline != null)
     	{
     		args["offline"] = Offline;
     	}

     	if (HttpCredentials != null)
     	{
     		args["httpCredentials"] = HttpCredentials;
     	}

     	if (DeviceScaleFactor != null)
     	{
     		args["deviceScaleFactor"] = DeviceScaleFactor;
     	}

     	if (IsMobile != null)
     	{
     		args["isMobile"] = IsMobile;
     	}

     	if (HasTouch != null)
     	{
     		args["hasTouch"] = HasTouch;
     	}

     	if (ColorScheme != null)
     	{
     		args["colorScheme"] = ColorScheme;
     	}

     	if (AcceptDownloads != null)
     	{
     		args["acceptDownloads"] = AcceptDownloads;
     	}

     	if (_traceResourcesPath != null)
     	{
     		args["_traceResourcesPath"] = _traceResourcesPath;
     	}

     	if (_tracePath != null)
     	{
     		args["_tracePath"] = _tracePath;
     	}

     	if (RecordVideo != null)
     	{
     		args["recordVideo"] = RecordVideo;
     	}

     	if (RecordHar != null)
     	{
     		args["recordHar"] = RecordHar;
     	}

     	if (Proxy != null)
     	{
     		args["proxy"] = Proxy;
     	}

     	if (StorageState != null)
     	{
     		args["storageState"] = StorageState;
     	}
     	return await Connection.SendMessageToServerAsync<BrowserContext>(Guid, "newContext", args);
     }

     public async Task<CDPSession> CrNewBrowserCDPSessionAsync()
     	=> await Connection.SendMessageToServerAsync<CDPSessionChannel>(Guid, "crNewBrowserCDPSession", null);

     public async Task CrStartTracingAsync(Page? Page, string Path, bool? Screenshots, string[] Categories)
     {
     	var args = new Dictionary<string, object> ();

     	if (Page != null)
     	{
     	}

     	if (Path != null)
     	{
     		args["path"] = Path;
     	}

     	if (Screenshots != null)
     	{
     		args["screenshots"] = Screenshots;
     	}

     	if (Categories != null)
     	{
     		args["categories"] = Categories;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "crStartTracing", args);
     }

     public async Task<string> CrStopTracingAsync()
     	=> (await Connection.SendMessageToServerAsync(Guid, "crStopTracing", null).ConfigureAwait(false))?.GetProperty("Binary").ToString();
   }
}