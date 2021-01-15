using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    public partial class AXNode
    {
		[JsonPropertyName("role")]
		public string Role { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("valueString")]
		public string ValueString { get; set; }

		[JsonPropertyName("valueNumber")]
		public double? ValueNumber { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("keyshortcuts")]
		public string Keyshortcuts { get; set; }

		[JsonPropertyName("roledescription")]
		public string Roledescription { get; set; }

		[JsonPropertyName("valuetext")]
		public string Valuetext { get; set; }

		[JsonPropertyName("disabled")]
		public bool? Disabled { get; set; }

		[JsonPropertyName("expanded")]
		public bool? Expanded { get; set; }

		[JsonPropertyName("focused")]
		public bool? Focused { get; set; }

		[JsonPropertyName("modal")]
		public bool? Modal { get; set; }

		[JsonPropertyName("multiline")]
		public bool? Multiline { get; set; }

		[JsonPropertyName("multiselectable")]
		public bool? Multiselectable { get; set; }

		[JsonPropertyName("readonly")]
		public bool? @readonly { get; set; }

		[JsonPropertyName("required")]
		public bool? Required { get; set; }

		[JsonPropertyName("selected")]
		public bool? Selected { get; set; }

		[JsonPropertyName("checked")]
		public CheckedEnum? @checked { get; set; }

		[JsonPropertyName("pressed")]
		public PressedEnum? Pressed { get; set; }

		[JsonPropertyName("level")]
		public double? Level { get; set; }

		[JsonPropertyName("valuemin")]
		public double? Valuemin { get; set; }

		[JsonPropertyName("valuemax")]
		public double? Valuemax { get; set; }

		[JsonPropertyName("autocomplete")]
		public string Autocomplete { get; set; }

		[JsonPropertyName("haspopup")]
		public string Haspopup { get; set; }

		[JsonPropertyName("invalid")]
		public string Invalid { get; set; }

		[JsonPropertyName("orientation")]
		public string Orientation { get; set; }

		[JsonPropertyName("children")]
		public AXNode[] Children { get; set; }


    }
}