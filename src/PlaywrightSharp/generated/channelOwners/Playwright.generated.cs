
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Playwright : ChannelOwnerBase, IChannelOwner<Playwright>
    {
        private readonly PlaywrightChannel _channel;
        public IChannel<PlaywrightChannel> Channel => _channel;

        private readonly PlaywrightInitializer  _initializer;

        public Playwright(IChannelOwner parent, string guid, PlaywrightInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new PlaywrightChannel(guid, parent.Connection, this);
        }
    }
}