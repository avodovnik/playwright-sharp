
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal partial class Worker : ChannelOwnerBase, IChannelOwner<Worker>
    {
        private readonly WorkerChannel _channel;
        public IChannel<WorkerChannel> Channel => _channel;

        private readonly WorkerInitializer  _initializer;

        public Worker(IChannelOwner parent, string guid, WorkerInitializer initializer)
                : base(parent, guid, initializer)
        {
            _channel = new WorkerChannel(guid, parent.Connection, this);
        }
    }
}