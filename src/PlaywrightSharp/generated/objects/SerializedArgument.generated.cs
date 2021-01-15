using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class SerializedArgument
    {
		[JsonPropertyName("value")]
		public SerializedValue Value { get; set; }

		[JsonPropertyName("handles")]
		public Channel[] Handles { get; set; }


    }
}