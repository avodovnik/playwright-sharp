using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class FunctionsItem
    {
		[JsonPropertyName("functionName")]
		public string FunctionName { get; set; }

		[JsonPropertyName("isBlockCoverage")]
		public bool IsBlockCoverage { get; set; }

		[JsonPropertyName("ranges")]
		public RangesItem[] Ranges { get; set; }


    }
}