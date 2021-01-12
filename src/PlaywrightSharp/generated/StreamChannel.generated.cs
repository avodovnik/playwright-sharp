
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class StreamChannel : Channel<Stream>
    {
        public StreamChannel(string guid, Connection connection, Stream owner) : base(guid, connection, owner)
        {
        }

     public async Task<string> ReadAsync(double? Size)
     {
     	var args = new Dictionary<string, object> ();

     	if (Size != null)
     	{
     		args["size"] = Size;
     	}
     	// TODO: Verify if we should do something special with this binary type.
     	return (await Connection.SendMessageToServerAsync(Guid, "read", args).ConfigureAwait(false))?.GetProperty("binary").ToString();
     }

     public async Task CloseAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "close", null);
   }
}