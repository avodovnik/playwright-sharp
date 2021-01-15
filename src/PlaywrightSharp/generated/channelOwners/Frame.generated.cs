
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Frame : ChannelOwnerBase, IChannelOwner<Frame>
    {
        private readonly FrameChannel _channel;
        public IChannel<FrameChannel> Channel => _channel;

        private readonly FrameInitializer  _initializer;

        public Frame(IChannelOwner parent, string guid, FrameInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new FrameChannel(guid, parent.Connection, this);
        }
    }
}