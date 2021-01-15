
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class BrowserTypeChannel : Channel<BrowserType>
    {
        public BrowserTypeChannel(string guid, Connection connection, BrowserType owner) : base(guid, connection, owner)
        {
        }

     public async Task<Browser> LaunchAsync(string ExecutablePath, string[] Args, bool? IgnoreAllDefaultArgs, string[] IgnoreDefaultArgs, bool? HandleSIGINT, bool? HandleSIGTERM, bool? HandleSIGHUP, double? Timeout, NameValue[] Env, bool? Headless, bool? Devtools, Proxy Proxy, string DownloadsPath, object FirefoxUserPrefs, bool? ChromiumSandbox, double? SlowMo)
     {
     	var args = new Dictionary<string, object> ();

     	if (ExecutablePath != null)
     	{
     		args["executablePath"] = ExecutablePath;
     	}

     	if (Args != null)
     	{
     		args["args"] = Args;
     	}

     	if (IgnoreAllDefaultArgs != null)
     	{
     		args["ignoreAllDefaultArgs"] = IgnoreAllDefaultArgs;
     	}

     	if (IgnoreDefaultArgs != null)
     	{
     		args["ignoreDefaultArgs"] = IgnoreDefaultArgs;
     	}

     	if (HandleSIGINT != null)
     	{
     		args["handleSIGINT"] = HandleSIGINT;
     	}

     	if (HandleSIGTERM != null)
     	{
     		args["handleSIGTERM"] = HandleSIGTERM;
     	}

     	if (HandleSIGHUP != null)
     	{
     		args["handleSIGHUP"] = HandleSIGHUP;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (Env != null)
     	{
     		args["env"] = Env;
     	}

     	if (Headless != null)
     	{
     		args["headless"] = Headless;
     	}

     	if (Devtools != null)
     	{
     		args["devtools"] = Devtools;
     	}

     	if (Proxy != null)
     	{
     		args["proxy"] = Proxy;
     	}

     	if (DownloadsPath != null)
     	{
     		args["downloadsPath"] = DownloadsPath;
     	}

     	if (FirefoxUserPrefs != null)
     	{
     		args["firefoxUserPrefs"] = FirefoxUserPrefs;
     	}

     	if (ChromiumSandbox != null)
     	{
     		args["chromiumSandbox"] = ChromiumSandbox;
     	}

     	if (SlowMo != null)
     	{
     		args["slowMo"] = SlowMo;
     	}
     	return await Connection.SendMessageToServerAsync<Browser>(Guid, "launch", args);
     }

     public async Task<BrowserContext> LaunchPersistentContextAsync(string UserDataDir, string ExecutablePath, string[] Args, bool? IgnoreAllDefaultArgs, string[] IgnoreDefaultArgs, bool? HandleSIGINT, bool? HandleSIGTERM, bool? HandleSIGHUP, double? Timeout, NameValue[] Env, bool? Headless, bool? Devtools, Proxy Proxy, string DownloadsPath, bool? ChromiumSandbox, double? SlowMo, bool? NoDefaultViewport, Viewport Viewport, bool? IgnoreHTTPSErrors, bool? JavaScriptEnabled, bool? BypassCSP, string UserAgent, string Locale, string TimezoneId, Geolocation Geolocation, string[] Permissions, NameValue[] ExtraHTTPHeaders, bool? Offline, HttpCredentials HttpCredentials, double? DeviceScaleFactor, bool? IsMobile, bool? HasTouch, BrowserTypeColorSchemeEnum? ColorScheme, bool? AcceptDownloads, string _traceResourcesPath, string _tracePath, RecordVideo RecordVideo, RecordHar RecordHar)
     {
     	var args = new Dictionary<string, object> ();

     	if (UserDataDir != null)
     	{
     		args["userDataDir"] = UserDataDir;
     	}

     	if (ExecutablePath != null)
     	{
     		args["executablePath"] = ExecutablePath;
     	}

     	if (Args != null)
     	{
     		args["args"] = Args;
     	}

     	if (IgnoreAllDefaultArgs != null)
     	{
     		args["ignoreAllDefaultArgs"] = IgnoreAllDefaultArgs;
     	}

     	if (IgnoreDefaultArgs != null)
     	{
     		args["ignoreDefaultArgs"] = IgnoreDefaultArgs;
     	}

     	if (HandleSIGINT != null)
     	{
     		args["handleSIGINT"] = HandleSIGINT;
     	}

     	if (HandleSIGTERM != null)
     	{
     		args["handleSIGTERM"] = HandleSIGTERM;
     	}

     	if (HandleSIGHUP != null)
     	{
     		args["handleSIGHUP"] = HandleSIGHUP;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}

     	if (Env != null)
     	{
     		args["env"] = Env;
     	}

     	if (Headless != null)
     	{
     		args["headless"] = Headless;
     	}

     	if (Devtools != null)
     	{
     		args["devtools"] = Devtools;
     	}

     	if (Proxy != null)
     	{
     		args["proxy"] = Proxy;
     	}

     	if (DownloadsPath != null)
     	{
     		args["downloadsPath"] = DownloadsPath;
     	}

     	if (ChromiumSandbox != null)
     	{
     		args["chromiumSandbox"] = ChromiumSandbox;
     	}

     	if (SlowMo != null)
     	{
     		args["slowMo"] = SlowMo;
     	}

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
     	return await Connection.SendMessageToServerAsync<BrowserContext>(Guid, "launchPersistentContext", args);
     }
   }
}