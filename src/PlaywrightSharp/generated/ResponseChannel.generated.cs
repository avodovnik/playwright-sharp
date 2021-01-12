
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class ResponseChannel : Channel<Response>
    {
        public ResponseChannel(string guid, Connection connection, Response owner) : base(guid, connection, owner)
        {
        }

     public async Task<string> BodyAsync()
     	=> (await Connection.SendMessageToServerAsync(Guid, "body", null).ConfigureAwait(false))?.GetProperty("Binary").ToString();

     public async Task<string> FinishedAsync()
     => throw new NotImplementedException();
   }
}