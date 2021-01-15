
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum PlaywrightDefaultBrowserTypeEnum 
    {
		[EnumMember(Value = "chromium")]
		Chromium,
		[EnumMember(Value = "firefox")]
		Firefox,
		[EnumMember(Value = "webkit")]
		Webkit,
	}
}