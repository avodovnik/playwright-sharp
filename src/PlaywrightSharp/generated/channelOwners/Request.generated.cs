
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Request : ChannelOwnerBase, IChannelOwner<Request>
    {
        private readonly RequestChannel _channel;
        public IChannel<RequestChannel> Channel => _channel;

        private readonly RequestInitializer  _initializer;

        public Request(IChannelOwner parent, string guid, RequestInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new RequestChannel(guid, parent.Connection, this);
        }
    }
}