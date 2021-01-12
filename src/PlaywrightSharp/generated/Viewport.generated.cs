using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class Viewport
    {
		[JsonPropertyName("width")]
		public double Width { get; set; }

		[JsonPropertyName("height")]
		public double Height { get; set; }


    }
}