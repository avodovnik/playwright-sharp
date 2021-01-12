using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class Metadata
    {
		[JsonPropertyName("stack")]
		public string Stack { get; set; }


    }
}