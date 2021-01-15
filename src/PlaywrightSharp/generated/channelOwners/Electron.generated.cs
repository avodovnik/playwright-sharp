
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Electron : ChannelOwnerBase, IChannelOwner<Electron>
    {
        private readonly ElectronChannel _channel;
        public IChannel<ElectronChannel> Channel => _channel;


        public Electron(IChannelOwner parent, string guid)
                : base(parent, guid)
        {
            _channel = new ElectronChannel(guid, parent.Connection, this);
        }
    }
}