
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Request : ChannelOwnerBase, IChannelOwner<Request>
    {
        private readonly RequestChannel _channel;
        private readonly RequestInitializer  _initializer;

        public Request()
        {
            // TODO: generate
        }
    }
}