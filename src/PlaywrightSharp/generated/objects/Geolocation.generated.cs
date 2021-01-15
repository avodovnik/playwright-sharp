using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class Geolocation
    {
		[JsonPropertyName("longitude")]
		public double Longitude { get; set; }

		[JsonPropertyName("latitude")]
		public double Latitude { get; set; }

		[JsonPropertyName("accuracy")]
		public double? Accuracy { get; set; }


    }
}