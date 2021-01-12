using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class Clip
    {
		[JsonPropertyName("width")]
		public double Width { get; set; }

		[JsonPropertyName("height")]
		public double Height { get; set; }

		[JsonPropertyName("x")]
		public double X { get; set; }

		[JsonPropertyName("y")]
		public double Y { get; set; }


    }
}