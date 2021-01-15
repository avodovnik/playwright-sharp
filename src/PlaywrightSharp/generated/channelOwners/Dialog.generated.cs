
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Dialog : ChannelOwnerBase, IChannelOwner<Dialog>
    {
        private readonly DialogChannel _channel;
        public IChannel<DialogChannel> Channel => _channel;

        private readonly DialogInitializer  _initializer;

        public Dialog(IChannelOwner parent, string guid, DialogInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new DialogChannel(guid, parent.Connection, this);
        }
    }
}