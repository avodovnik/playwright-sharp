using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class OptionsItem
    {
		[JsonPropertyName("value")]
		public string Value { get; set; }

		[JsonPropertyName("label")]
		public string Label { get; set; }

		[JsonPropertyName("index")]
		public double? Index { get; set; }


    }
}