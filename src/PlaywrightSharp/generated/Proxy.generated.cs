using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class Proxy
    {
		[JsonPropertyName("server")]
		public string Server { get; set; }

		[JsonPropertyName("bypass")]
		public string Bypass { get; set; }

		[JsonPropertyName("username")]
		public string Username { get; set; }

		[JsonPropertyName("password")]
		public string Password { get; set; }


    }
}