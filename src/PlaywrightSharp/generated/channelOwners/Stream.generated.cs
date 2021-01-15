
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Stream : ChannelOwnerBase, IChannelOwner<Stream>
    {
        private readonly StreamChannel _channel;
        public IChannel<StreamChannel> Channel => _channel;


        public Stream(IChannelOwner parent, string guid)
                : base(parent, guid)
        {
            _channel = new StreamChannel(guid, parent.Connection, this);
        }
    }
}