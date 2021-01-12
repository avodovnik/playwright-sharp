
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Dialog : ChannelOwnerBase, IChannelOwner<Dialog>
    {
        private readonly DialogChannel _channel;
        private readonly DialogInitializer  _initializer;

        public Dialog()
        {
            // TODO: generate
        }
    }
}