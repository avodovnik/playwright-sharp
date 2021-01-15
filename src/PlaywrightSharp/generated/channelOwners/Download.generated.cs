
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Download : ChannelOwnerBase, IChannelOwner<Download>
    {
        private readonly DownloadChannel _channel;
        public IChannel<DownloadChannel> Channel => _channel;

        private readonly DownloadInitializer  _initializer;

        public Download(IChannelOwner parent, string guid, DownloadInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new DownloadChannel(guid, parent.Connection, this);
        }
    }
}