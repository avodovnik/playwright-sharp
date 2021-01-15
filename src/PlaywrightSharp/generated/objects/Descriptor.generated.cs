using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class Descriptor
    {
		[JsonPropertyName("userAgent")]
		public string UserAgent { get; set; }

		[JsonPropertyName("viewport")]
		public Viewport Viewport { get; set; }

		[JsonPropertyName("deviceScaleFactor")]
		public double DeviceScaleFactor { get; set; }

		[JsonPropertyName("isMobile")]
		public bool IsMobile { get; set; }

		[JsonPropertyName("hasTouch")]
		public bool HasTouch { get; set; }

		[JsonPropertyName("defaultBrowserType")]
		public PlaywrightDefaultBrowserTypeEnum DefaultBrowserType { get; set; }


    }
}