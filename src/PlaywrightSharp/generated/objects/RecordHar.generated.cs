using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class RecordHar
    {
		[JsonPropertyName("omitContent")]
		public bool? OmitContent { get; set; }

		[JsonPropertyName("path")]
		public string Path { get; set; }


    }
}