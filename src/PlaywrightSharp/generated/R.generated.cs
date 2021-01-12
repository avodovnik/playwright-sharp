using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class R
    {
		[JsonPropertyName("p")]
		public string P { get; set; }

		[JsonPropertyName("f")]
		public string F { get; set; }


    }
}