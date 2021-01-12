using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class RangesItem
    {
		[JsonPropertyName("startOffset")]
		public double StartOffset { get; set; }

		[JsonPropertyName("endOffset")]
		public double EndOffset { get; set; }

		[JsonPropertyName("count")]
		public double Count { get; set; }


    }
}