
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Route : ChannelOwnerBase, IChannelOwner<Route>
    {
        private readonly RouteChannel _channel;
        private readonly RouteInitializer  _initializer;

        public Route()
        {
            // TODO: generate
        }
    }
}