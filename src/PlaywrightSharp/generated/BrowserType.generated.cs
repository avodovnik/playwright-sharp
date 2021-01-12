
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class BrowserType : ChannelOwnerBase, IChannelOwner<BrowserType>
    {
        private readonly BrowserTypeChannel _channel;
        private readonly BrowserTypeInitializer  _initializer;

        public BrowserType()
        {
            // TODO: generate
        }
    }
}