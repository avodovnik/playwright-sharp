
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class ElectronChannel : Channel<Electron>
    {
        public ElectronChannel(string guid, Connection connection, Electron owner) : base(guid, connection, owner)
        {
        }

     public async Task<ElectronApplication> LaunchAsync(string ExecutablePath, string[] Args, string Cwd, NameValue[] Env, bool? HandleSIGINT, bool? HandleSIGTERM, bool? HandleSIGHUP, double? Timeout)
     {
     	var args = new Dictionary<string, object> ();

     	if (ExecutablePath != null)
     	{
     		args["executablePath"] = ExecutablePath;
     	}

     	if (Args != null)
     	{
     		args["args"] = Args;
     	}

     	if (Cwd != null)
     	{
     		args["cwd"] = Cwd;
     	}

     	if (Env != null)
     	{
     		args["env"] = Env;
     	}

     	if (HandleSIGINT != null)
     	{
     		args["handleSIGINT"] = HandleSIGINT;
     	}

     	if (HandleSIGTERM != null)
     	{
     		args["handleSIGTERM"] = HandleSIGTERM;
     	}

     	if (HandleSIGHUP != null)
     	{
     		args["handleSIGHUP"] = HandleSIGHUP;
     	}

     	if (Timeout != null)
     	{
     		args["timeout"] = Timeout;
     	}
     	return await Connection.SendMessageToServerAsync<ElectronApplication>(Guid, "launch", args);
     }
   }
}