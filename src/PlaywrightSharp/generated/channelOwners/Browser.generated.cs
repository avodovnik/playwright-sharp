
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Browser : ChannelOwnerBase, IChannelOwner<Browser>
    {
        private readonly BrowserChannel _channel;
        public IChannel<BrowserChannel> Channel => _channel;

        private readonly BrowserInitializer  _initializer;

        public Browser(IChannelOwner parent, string guid, BrowserInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new BrowserChannel(guid, parent.Connection, this);
        }
    }
}