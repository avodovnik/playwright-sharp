using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class StorageState
    {
		[JsonPropertyName("cookies")]
		public SetNetworkCookie[] Cookies { get; set; }

		[JsonPropertyName("origins")]
		public OriginStorage[] Origins { get; set; }


    }
}