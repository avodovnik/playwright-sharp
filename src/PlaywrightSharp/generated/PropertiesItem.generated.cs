using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class PropertiesItem
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("value")]
		public JSHandle Value { get; set; }


    }
}