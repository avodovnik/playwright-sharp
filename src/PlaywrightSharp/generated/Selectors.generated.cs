
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Selectors : ChannelOwnerBase, IChannelOwner<Selectors>
    {
        private readonly SelectorsChannel _channel;

        public Selectors()
        {
            // TODO: generate
        }
    }
}