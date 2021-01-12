
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class JSHandleChannel : Channel<JSHandle>
    {
        public JSHandleChannel(string guid, Connection connection, JSHandle owner) : base(guid, connection, owner)
        {
        }

     public async Task DisposeAsync()
     	=> Connection.SendMessageToServerAsync(Guid, "dispose", null);

     public async Task<SerializedValue> EvaluateExpressionAsync(string Expression, bool IsFunction, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;
     	return await Connection.SendMessageToServerAsync<SerializedValue>(Guid, "evaluateExpression", args);
     }

     public async Task<JSHandle> EvaluateExpressionHandleAsync(string Expression, bool IsFunction, SerializedArgument Arg)
     {
     	var args = new Dictionary<string, object> ();

     	if (Expression != null)
     	{
     		args["expression"] = Expression;
     	}
     	args["isFunction"] = IsFunction;
     	return await Connection.SendMessageToServerAsync<JSHandle>(Guid, "evaluateExpressionHandle", args);
     }

     public async Task<PropertiesItem[]> GetPropertyListAsync()
     => throw new NotImplementedException();

     public async Task<JSHandle> GetPropertyAsync(string Name)
     {
     	var args = new Dictionary<string, object> ();

     	if (Name != null)
     	{
     		args["name"] = Name;
     	}
     	return await Connection.SendMessageToServerAsync<JSHandle>(Guid, "getProperty", args);
     }

     public async Task<SerializedValue> JsonValueAsync()
=> throw new NotImplementedException();
   }
}