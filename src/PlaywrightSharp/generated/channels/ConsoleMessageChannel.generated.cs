
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class ConsoleMessageChannel : Channel<ConsoleMessage>
    {
        public ConsoleMessageChannel(string guid, Connection connection, ConsoleMessage owner) : base(guid, connection, owner)
        {
        }
   }
}