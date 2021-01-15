
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Selectors : ChannelOwnerBase, IChannelOwner<Selectors>
    {
        private readonly SelectorsChannel _channel;
        public IChannel<SelectorsChannel> Channel => _channel;


        public Selectors(IChannelOwner parent, string guid)
                : base(parent, guid)
        {
            _channel = new SelectorsChannel(guid, parent.Connection, this);
        }
    }
}