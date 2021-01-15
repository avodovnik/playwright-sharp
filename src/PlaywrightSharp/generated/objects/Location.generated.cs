using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class Location
    {
		[JsonPropertyName("url")]
		public string Url { get; set; }

		[JsonPropertyName("lineNumber")]
		public double LineNumber { get; set; }

		[JsonPropertyName("columnNumber")]
		public double ColumnNumber { get; set; }


    }
}