
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class JSHandle : ChannelOwnerBase, IChannelOwner<JSHandle>
    {
        private readonly JSHandleChannel _channel;
        private readonly JSHandleInitializer  _initializer;

        public JSHandle()
        {
            // TODO: generate
        }
    }
}