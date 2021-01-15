
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport;
using PlaywrightSharp.Transport.Channels;
using PlaywrightSharp.Transport.Protocol;

namespace PlaywrightSharp
{
    internal partial class BindingCall : ChannelOwnerBase, IChannelOwner<BindingCall>
    {
        private readonly BindingCallChannel _channel;
        public IChannel<BindingCall> Channel => _channel;

        private readonly BindingCallInitializer  _initializer;

        public BindingCall(IChannelOwner parent, string guid, BindingCallInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new BindingCallChannel(guid, parent.Connection, this);
            Initialize();
        }

        internal virtual void Initialize()
        {

        }
    }
}
