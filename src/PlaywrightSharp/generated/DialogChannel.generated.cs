
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class DialogChannel : Channel<Dialog>
    {
        public DialogChannel(string guid, Connection connection, Dialog owner) : base(guid, connection, owner)
        {
        }

     public async Task AcceptAsync(string PromptText)
     {
     	var args = new Dictionary<string, object> ();

     	if (PromptText != null)
     	{
     		args["promptText"] = PromptText;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "accept", args);
     }

     public async Task DismissAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "dismiss", null);
   }
}