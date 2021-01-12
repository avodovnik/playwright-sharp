
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Electron : ChannelOwnerBase, IChannelOwner<Electron>
    {
        private readonly ElectronChannel _channel;

        public Electron()
        {
            // TODO: generate
        }
    }
}