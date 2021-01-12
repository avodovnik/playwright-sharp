
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Download : ChannelOwnerBase, IChannelOwner<Download>
    {
        private readonly DownloadChannel _channel;
        private readonly DownloadInitializer  _initializer;

        public Download()
        {
            // TODO: generate
        }
    }
}