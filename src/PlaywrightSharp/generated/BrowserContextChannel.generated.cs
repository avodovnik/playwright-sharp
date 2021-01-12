
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class BrowserContextChannel : Channel<BrowserContext>
    {
        public BrowserContextChannel(string guid, Connection connection, BrowserContext owner) : base(guid, connection, owner)
        {
        }

     public async Task AddCookiesAsync(SetNetworkCookie[] Cookies)
     {
     	var args = new Dictionary<string, object> ();

     	if (Cookies != null)
     	{
     		args["cookies"] = Cookies;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "addCookies", args);
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

     public async Task ClearCookiesAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "clearCookies", null);

     public async Task ClearPermissionsAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "clearPermissions", null);

     public async Task CloseAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "close", null);

     public async Task<NetworkCookie[]> CookiesAsync(string[] Urls)
     {
     	var args = new Dictionary<string, object> ();

     	if (Urls != null)
     	{
     		args["urls"] = Urls;
     	}
     	return await Connection.SendMessageToServerAsync<NetworkCookie[]>(Guid, "cookies", args);
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

     public async Task GrantPermissionsAsync(string[] Permissions, string Origin)
     {
     	var args = new Dictionary<string, object> ();

     	if (Permissions != null)
     	{
     		args["permissions"] = Permissions;
     	}

     	if (Origin != null)
     	{
     		args["origin"] = Origin;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "grantPermissions", args);
     }

     public async Task<Page> NewPageAsync()
     	=> await Connection.SendMessageToServerAsync<PageChannel>(Guid, "newPage", null);

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

     public async Task SetExtraHTTPHeadersAsync(NameValue[] Headers)
     {
     	var args = new Dictionary<string, object> ();

     	if (Headers != null)
     	{
     		args["headers"] = Headers;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setExtraHTTPHeaders", args);
     }

     public async Task SetGeolocationAsync(Geolocation Geolocation)
     {
     	var args = new Dictionary<string, object> ();

     	if (Geolocation != null)
     	{
     		args["geolocation"] = Geolocation;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setGeolocation", args);
     }

     public async Task SetHTTPCredentialsAsync(HttpCredentials HttpCredentials)
     {
     	var args = new Dictionary<string, object> ();

     	if (HttpCredentials != null)
     	{
     		args["httpCredentials"] = HttpCredentials;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "setHTTPCredentials", args);
     }

     public async Task SetNetworkInterceptionEnabledAsync(bool Enabled)
     {
     	var args = new Dictionary<string, object> ();
     	args["enabled"] = Enabled;
     	await Connection.SendMessageToServerAsync(Guid, "setNetworkInterceptionEnabled", args);
     }

     public async Task SetOfflineAsync(bool Offline)
     {
     	var args = new Dictionary<string, object> ();
     	args["offline"] = Offline;
     	await Connection.SendMessageToServerAsync(Guid, "setOffline", args);
     }

     public async Task<NetworkCookie[]> StorageStateAsync()
     => throw new NotImplementedException();

     public async Task<CDPSession> CrNewCDPSessionAsync(Page Page)
     {
     	var args = new Dictionary<string, object> ();
     	return await Connection.SendMessageToServerAsync<CDPSession>(Guid, "crNewCDPSession", args);
     }
   }
}