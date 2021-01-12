
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class BrowserContext : ChannelOwnerBase, IChannelOwner<BrowserContext>
    {
        private readonly BrowserContextChannel _channel;
        private readonly BrowserContextInitializer  _initializer;

        public BrowserContext()
        {
            // TODO: generate
        }
    }
}