using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class RequestHeadersItem
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("value")]
		public string Value { get; set; }


    }
}