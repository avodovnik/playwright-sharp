
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class ElectronApplication : ChannelOwnerBase, IChannelOwner<ElectronApplication>
    {
        private readonly ElectronApplicationChannel _channel;

        public ElectronApplication()
        {
            // TODO: generate
        }
    }
}