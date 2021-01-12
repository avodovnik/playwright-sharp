
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Browser : ChannelOwnerBase, IChannelOwner<Browser>
    {
        private readonly BrowserChannel _channel;
        private readonly BrowserInitializer  _initializer;

        public Browser()
        {
            // TODO: generate
        }
    }
}