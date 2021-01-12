
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Response : ChannelOwnerBase, IChannelOwner<Response>
    {
        private readonly ResponseChannel _channel;
        private readonly ResponseInitializer  _initializer;

        public Response()
        {
            // TODO: generate
        }
    }
}