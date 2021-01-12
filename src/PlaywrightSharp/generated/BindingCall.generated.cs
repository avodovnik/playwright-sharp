
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class BindingCall : ChannelOwnerBase, IChannelOwner<BindingCall>
    {
        private readonly BindingCallChannel _channel;
        private readonly BindingCallInitializer  _initializer;

        public BindingCall()
        {
            // TODO: generate
        }
    }
}