using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class Position
    {
		[JsonPropertyName("x")]
		public double X { get; set; }

		[JsonPropertyName("y")]
		public double Y { get; set; }


    }
}