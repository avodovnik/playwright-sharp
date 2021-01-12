using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class OriginStorage
    {
		[JsonPropertyName("origin")]
		public string Origin { get; set; }

		[JsonPropertyName("localStorage")]
		public NameValue[] LocalStorage { get; set; }


    }
}