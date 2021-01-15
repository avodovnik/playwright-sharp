
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class ConsoleMessage : ChannelOwnerBase, IChannelOwner<ConsoleMessage>
    {
        private readonly ConsoleMessageChannel _channel;
        public IChannel<ConsoleMessageChannel> Channel => _channel;

        private readonly ConsoleMessageInitializer  _initializer;

        public ConsoleMessage(IChannelOwner parent, string guid, ConsoleMessageInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new ConsoleMessageChannel(guid, parent.Connection, this);
        }
    }
}