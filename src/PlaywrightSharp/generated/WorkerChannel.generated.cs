
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class WorkerChannel : Channel<Worker>
    {
        public WorkerChannel(string guid, Connection connection, Worker owner) : base(guid, connection, owner)
        {
        }

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
   }
}