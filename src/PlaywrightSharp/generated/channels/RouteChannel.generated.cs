
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlaywrightSharp.Models;

namespace PlaywrightSharp.Transport.Channels
{
    internal partial class RouteChannel : Channel<Route>
    {
        public RouteChannel(string guid, Connection connection, Route owner) : base(guid, connection, owner)
        {
        }

     public async Task AbortAsync(string ErrorCode)
     {
     	var args = new Dictionary<string, object> ();

     	if (ErrorCode != null)
     	{
     		args["errorCode"] = ErrorCode;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "abort", args);
     }

     public async Task ContinueAsync(string Url, string Method, NameValue[] Headers, string PostData)
     {
     	var args = new Dictionary<string, object> ();

     	if (Url != null)
     	{
     		args["url"] = Url;
     	}

     	if (Method != null)
     	{
     		args["method"] = Method;
     	}

     	if (Headers != null)
     	{
     		args["headers"] = Headers;
     	}

     	if (PostData != null)
     	{
     		args["postData"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(PostData));
     	}
     	await Connection.SendMessageToServerAsync(Guid, "continue", args);
     }

     public async Task FulfillAsync(double? Status, NameValue[] Headers, string Body, bool? IsBase64)
     {
     	var args = new Dictionary<string, object> ();

     	if (Status != null)
     	{
     		args["status"] = Status;
     	}

     	if (Headers != null)
     	{
     		args["headers"] = Headers;
     	}

     	if (Body != null)
     	{
     		args["body"] = Body;
     	}

     	if (IsBase64 != null)
     	{
     		args["isBase64"] = IsBase64;
     	}
     	await Connection.SendMessageToServerAsync(Guid, "fulfill", args);
     }
   }
}