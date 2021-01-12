
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class DownloadChannel : Channel<Download>
    {
        public DownloadChannel(string guid, Connection connection, Download owner) : base(guid, connection, owner)
        {
        }

     public async Task<string> PathAsync()
     => throw new NotImplementedException();

     public async Task SaveAsAsync(string Path)
     {
     	var args = new Dictionary<string, object> ();

     	if (Path != null)
     	{
     		args["path"] = Path;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "saveAs", args);
     }

     public async Task<Stream> SaveAsStreamAsync()
     	=> await Connection.SendMessageToServerAsync<StreamChannel>(Guid, "saveAsStream", null);

     public async Task<string> FailureAsync()
     => throw new NotImplementedException();

     public async Task<Stream?> StreamAsync()
     	=> await Connection.SendMessageToServerAsync<StreamChannel>(Guid, "stream", null);

     public async Task DeleteAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "delete", null);
   }
}