
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class ConsoleMessage : ChannelOwnerBase, IChannelOwner<ConsoleMessage>
    {
        private readonly ConsoleMessageChannel _channel;
        private readonly ConsoleMessageInitializer  _initializer;

        public ConsoleMessage()
        {
            // TODO: generate
        }
    }
}