
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class RequestChannel : Channel<Request>
    {
        public RequestChannel(string guid, Connection connection, Request owner) : base(guid, connection, owner)
        {
        }

     public async Task<Response?> ResponseAsync()
     	=> await Connection.SendMessageToServerAsync<ResponseChannel>(Guid, "response", null);
   }
}