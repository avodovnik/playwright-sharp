using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class HttpCredentials
    {
		[JsonPropertyName("username")]
		public string Username { get; set; }

		[JsonPropertyName("password")]
		public string Password { get; set; }


    }
}