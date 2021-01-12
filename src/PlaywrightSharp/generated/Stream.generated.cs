
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Stream : ChannelOwnerBase, IChannelOwner<Stream>
    {
        private readonly StreamChannel _channel;

        public Stream()
        {
            // TODO: generate
        }
    }
}