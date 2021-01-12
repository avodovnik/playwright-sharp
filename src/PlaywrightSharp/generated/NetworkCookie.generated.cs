using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class NetworkCookie
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("value")]
		public string Value { get; set; }

		[JsonPropertyName("domain")]
		public string Domain { get; set; }

		[JsonPropertyName("path")]
		public string Path { get; set; }

		[JsonPropertyName("expires")]
		public double Expires { get; set; }

		[JsonPropertyName("httpOnly")]
		public bool HttpOnly { get; set; }

		[JsonPropertyName("secure")]
		public bool Secure { get; set; }

		[JsonPropertyName("sameSite")]
		public SameSiteEnum SameSite { get; set; }


    }
}