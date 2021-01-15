
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class BrowserContext : ChannelOwnerBase, IChannelOwner<BrowserContext>
    {
        private readonly BrowserContextChannel _channel;
        public IChannel<BrowserContextChannel> Channel => _channel;

        private readonly BrowserContextInitializer  _initializer;

        public BrowserContext(IChannelOwner parent, string guid, BrowserContextInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new BrowserContextChannel(guid, parent.Connection, this);
        }
    }
}