
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Frame : ChannelOwnerBase, IChannelOwner<Frame>
    {
        private readonly FrameChannel _channel;
        private readonly FrameInitializer  _initializer;

        public Frame()
        {
            // TODO: generate
        }
    }
}