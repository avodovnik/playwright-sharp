
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Route : ChannelOwnerBase, IChannelOwner<Route>
    {
        private readonly RouteChannel _channel;
        public IChannel<RouteChannel> Channel => _channel;

        private readonly RouteInitializer  _initializer;

        public Route(IChannelOwner parent, string guid, RouteInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new RouteChannel(guid, parent.Connection, this);
        }
    }
}