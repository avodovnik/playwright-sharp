
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class CDPSession : ChannelOwnerBase, IChannelOwner<CDPSession>
    {
        private readonly CDPSessionChannel _channel;

        public CDPSession()
        {
            // TODO: generate
        }
    }
}