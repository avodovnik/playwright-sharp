
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class ElementHandle : ChannelOwnerBase, IChannelOwner<ElementHandle>
    {
        private readonly ElementHandleChannel _channel;

        public ElementHandle()
        {
            // TODO: generate
        }
    }
}