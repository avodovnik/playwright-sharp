
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class BrowserType : ChannelOwnerBase, IChannelOwner<BrowserType>
    {
        private readonly BrowserTypeChannel _channel;
        public IChannel<BrowserTypeChannel> Channel => _channel;

        private readonly BrowserTypeInitializer  _initializer;

        public BrowserType(IChannelOwner parent, string guid, BrowserTypeInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new BrowserTypeChannel(guid, parent.Connection, this);
        }
    }
}