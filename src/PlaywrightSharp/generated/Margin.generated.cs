using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class Margin
    {
		[JsonPropertyName("top")]
		public string Top { get; set; }

		[JsonPropertyName("bottom")]
		public string Bottom { get; set; }

		[JsonPropertyName("left")]
		public string Left { get; set; }

		[JsonPropertyName("right")]
		public string Right { get; set; }


    }
}