using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class OItem
    {
		[JsonPropertyName("k")]
		public string K { get; set; }

		[JsonPropertyName("v")]
		public SerializedValue V { get; set; }


    }
}