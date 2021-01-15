
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class ElectronApplication : ChannelOwnerBase, IChannelOwner<ElectronApplication>
    {
        private readonly ElectronApplicationChannel _channel;
        public IChannel<ElectronApplicationChannel> Channel => _channel;


        public ElectronApplication(IChannelOwner parent, string guid)
                : base(parent, guid)
        {
            _channel = new ElectronApplicationChannel(guid, parent.Connection, this);
        }
    }
}