
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Playwright : ChannelOwnerBase, IChannelOwner<Playwright>
    {
        private readonly PlaywrightChannel _channel;
        private readonly PlaywrightInitializer  _initializer;

        public Playwright()
        {
            // TODO: generate
        }
    }
}