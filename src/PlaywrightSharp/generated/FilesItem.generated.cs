using System;
using System.Text.Json.Serialization;
using PlaywrightSharp;
using PlaywrightSharp.Models;

namespace PlaywrightSharp
{
    internal partial class FilesItem
    {
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("mimeType")]
		public string MimeType { get; set; }

		[JsonPropertyName("buffer")]
		public string Buffer { get; set; }


    }
}