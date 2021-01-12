using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class SerializedError
    {
		[JsonPropertyName("error")]
		public Error Error { get; set; }

		[JsonPropertyName("value")]
		public SerializedValue? Value { get; set; }


    }
}