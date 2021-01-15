using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class EntriesItem
    {
		[JsonPropertyName("url")]
		public string Url { get; set; }

		[JsonPropertyName("scriptId")]
		public string ScriptId { get; set; }

		[JsonPropertyName("source")]
		public string Source { get; set; }

		[JsonPropertyName("functions")]
		public FunctionsItem[] Functions { get; set; }


    }
}