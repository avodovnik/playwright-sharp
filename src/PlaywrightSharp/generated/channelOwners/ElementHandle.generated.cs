
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class ElementHandle : ChannelOwnerBase, IChannelOwner<ElementHandle>
    {
        private readonly ElementHandleChannel _channel;
        public IChannel<ElementHandleChannel> Channel => _channel;


        public ElementHandle(IChannelOwner parent, string guid)
                : base(parent, guid)
        {
            _channel = new ElementHandleChannel(guid, parent.Connection, this);
        }
    }
}