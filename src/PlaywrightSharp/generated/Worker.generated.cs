
using System;
using System.Threading.Tasks;
using PlaywrightSharp;
using PlaywrightSharp.Models;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp.Transport
{
    internal partial class Worker : ChannelOwnerBase, IChannelOwner<Worker>
    {
        private readonly WorkerChannel _channel;
        private readonly WorkerInitializer  _initializer;

        public Worker()
        {
            // TODO: generate
        }
    }
}