
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class CDPSession : ChannelOwnerBase, IChannelOwner<CDPSession>
    {
        private readonly CDPSessionChannel _channel;
        public IChannel<CDPSessionChannel> Channel => _channel;


        public CDPSession(IChannelOwner parent, string guid)
                : base(parent, guid)
        {
            _channel = new CDPSessionChannel(guid, parent.Connection, this);
        }
    }
}