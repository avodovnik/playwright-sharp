using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class RecordVideo
    {
		[JsonPropertyName("dir")]
		public string Dir { get; set; }

		[JsonPropertyName("size")]
		public Size Size { get; set; }


    }
}