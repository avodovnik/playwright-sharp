
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class SelectorsChannel : Channel<Selectors>
    {
        public SelectorsChannel(string guid, Connection connection, Selectors owner) : base(guid, connection, owner)
        {
        }

     public async Task RegisterAsync(string Name, string Source, bool? ContentScript)
     {
     	var args = new Dictionary<string, object> ();

     	if (Name != null)
     	{
     		args["name"] = Name;
     	}

     	if (Source != null)
     	{
     		args["source"] = Source;
     	}

     	if (ContentScript != null)
     	{
     		args["contentScript"] = ContentScript;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "register", args);
     }
   }
}