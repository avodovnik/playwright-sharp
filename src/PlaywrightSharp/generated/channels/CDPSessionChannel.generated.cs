
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class CDPSessionChannel : Channel<CDPSession>
    {
        public CDPSessionChannel(string guid, Connection connection, CDPSession owner) : base(guid, connection, owner)
        {
        }

     public async Task<object> SendAsync(string Method, object @params)
     {
     	var args = new Dictionary<string, object> ();

     	if (Method != null)
     	{
     		args["method"] = Method;
     	}

     	if (@params != null)
     	{
     		args["@params"] = @params;
     	}
     	return (await Connection.SendMessageToServerAsync(Guid, "send", args).ConfigureAwait(false))?.GetProperty("result").ToString();
     }

     public async Task DetachAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "detach", null);
   }
}