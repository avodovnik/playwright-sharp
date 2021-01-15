using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class ResourceTiming
    {
		[JsonPropertyName("startTime")]
		public double StartTime { get; set; }

		[JsonPropertyName("domainLookupStart")]
		public double DomainLookupStart { get; set; }

		[JsonPropertyName("domainLookupEnd")]
		public double DomainLookupEnd { get; set; }

		[JsonPropertyName("connectStart")]
		public double ConnectStart { get; set; }

		[JsonPropertyName("secureConnectionStart")]
		public double SecureConnectionStart { get; set; }

		[JsonPropertyName("connectEnd")]
		public double ConnectEnd { get; set; }

		[JsonPropertyName("requestStart")]
		public double RequestStart { get; set; }

		[JsonPropertyName("responseStart")]
		public double ResponseStart { get; set; }


    }
}