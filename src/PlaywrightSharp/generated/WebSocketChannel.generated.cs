
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class WebSocketChannel : Channel<WebSocket>
    {
        public WebSocketChannel(string guid, Connection connection, WebSocket owner) : base(guid, connection, owner)
        {
        }
   }
}