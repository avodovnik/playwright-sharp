
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class WebSocket : ChannelOwnerBase, IChannelOwner<WebSocket>
    {
        private readonly WebSocketChannel _channel;
        private readonly WebSocketInitializer  _initializer;

        public WebSocket()
        {
            // TODO: generate
        }
    }
}