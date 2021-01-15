
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class JSHandle : ChannelOwnerBase, IChannelOwner<JSHandle>
    {
        private readonly JSHandleChannel _channel;
        public IChannel<JSHandleChannel> Channel => _channel;

        private readonly JSHandleInitializer  _initializer;

        public JSHandle(IChannelOwner parent, string guid, JSHandleInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new JSHandleChannel(guid, parent.Connection, this);
        }
    }
}