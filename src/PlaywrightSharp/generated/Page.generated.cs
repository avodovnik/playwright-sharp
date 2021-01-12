
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Page : ChannelOwnerBase, IChannelOwner<Page>
    {
        private readonly PageChannel _channel;
        private readonly PageInitializer  _initializer;

        public Page()
        {
            // TODO: generate
        }
    }
}