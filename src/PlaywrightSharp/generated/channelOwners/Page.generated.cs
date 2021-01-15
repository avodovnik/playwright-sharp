
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Page : ChannelOwnerBase, IChannelOwner<Page>
    {
        private readonly PageChannel _channel;
        public IChannel<PageChannel> Channel => _channel;

        private readonly PageInitializer  _initializer;

        public Page(IChannelOwner parent, string guid, PageInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new PageChannel(guid, parent.Connection, this);
        }
    }
}