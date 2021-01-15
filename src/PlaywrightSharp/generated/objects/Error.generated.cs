using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class Error
    {
		[JsonPropertyName("message")]
		public string Message { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("stack")]
		public string Stack { get; set; }


    }
}