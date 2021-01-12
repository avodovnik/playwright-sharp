
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class PlaywrightChannel : Channel<Playwright>
    {
        public PlaywrightChannel(string guid, Connection connection, Playwright owner) : base(guid, connection, owner)
        {
        }
   }
}