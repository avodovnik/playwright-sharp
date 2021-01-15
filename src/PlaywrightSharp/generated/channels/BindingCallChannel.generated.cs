
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class BindingCallChannel : Channel<BindingCall>
    {
        public BindingCallChannel(string guid, Connection connection, BindingCall owner) : base(guid, connection, owner)
        {
        }

     public async Task RejectAsync(SerializedError Error)
     {
     	var args = new Dictionary<string, object> ();
     	await Connection.SendMessageToServerAsync(Guid, "reject", args);
     }

     public async Task ResolveAsync(SerializedArgument Result)
     {
     	var args = new Dictionary<string, object> ();
     	await Connection.SendMessageToServerAsync(Guid, "resolve", args);
     }
   }
}