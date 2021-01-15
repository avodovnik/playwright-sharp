using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class SerializedValue
    {
		[JsonPropertyName("n")]
		public double? N { get; set; }

		[JsonPropertyName("b")]
		public bool? B { get; set; }

		[JsonPropertyName("s")]
		public string S { get; set; }

		[JsonPropertyName("v")]
		public VEnum? V { get; set; }

		[JsonPropertyName("d")]
		public string D { get; set; }

		[JsonPropertyName("r")]
		public R R { get; set; }

		[JsonPropertyName("a")]
		public SerializedValue[] A { get; set; }

		[JsonPropertyName("o")]
		public OItem[] O { get; set; }

		[JsonPropertyName("h")]
		public double? H { get; set; }


    }
}