
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class RemoteBrowser : ChannelOwnerBase, IChannelOwner<RemoteBrowser>
    {
        private readonly RemoteBrowserChannel _channel;
        public IChannel<RemoteBrowserChannel> Channel => _channel;

        private readonly RemoteBrowserInitializer  _initializer;

        public RemoteBrowser(IChannelOwner parent, string guid, RemoteBrowserInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new RemoteBrowserChannel(guid, parent.Connection, this);
        }
    }
}