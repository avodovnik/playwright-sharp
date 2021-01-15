
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Response : ChannelOwnerBase, IChannelOwner<Response>
    {
        private readonly ResponseChannel _channel;
        public IChannel<ResponseChannel> Channel => _channel;

        private readonly ResponseInitializer  _initializer;

        public Response(IChannelOwner parent, string guid, ResponseInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new ResponseChannel(guid, parent.Connection, this);
        }
    }
}