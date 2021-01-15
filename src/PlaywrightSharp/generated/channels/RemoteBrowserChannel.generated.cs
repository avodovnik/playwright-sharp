
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class RemoteBrowserChannel : Channel<RemoteBrowser>
    {
        public RemoteBrowserChannel(string guid, Connection connection, RemoteBrowser owner) : base(guid, connection, owner)
        {
        }
   }
}