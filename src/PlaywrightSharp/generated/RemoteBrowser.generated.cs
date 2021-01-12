
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class RemoteBrowser : ChannelOwnerBase, IChannelOwner<RemoteBrowser>
    {
        private readonly RemoteBrowserChannel _channel;
        private readonly RemoteBrowserInitializer  _initializer;

        public RemoteBrowser()
        {
            // TODO: generate
        }
    }
}