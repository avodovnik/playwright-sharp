using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class DeviceDescriptorsItem
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("descriptor")]
		public Descriptor Descriptor { get; set; }


    }
}