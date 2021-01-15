
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class WebSocket : ChannelOwnerBase, IChannelOwner<WebSocket>
    {
        private readonly WebSocketChannel _channel;
        public IChannel<WebSocketChannel> Channel => _channel;

        private readonly WebSocketInitializer  _initializer;

        public WebSocket(IChannelOwner parent, string guid, WebSocketInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new WebSocketChannel(guid, parent.Connection, this);
        }
    }
}