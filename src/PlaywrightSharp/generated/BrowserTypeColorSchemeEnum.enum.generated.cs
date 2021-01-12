
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum BrowserTypeColorSchemeEnum 
    {
		[EnumMember(Value = "light")]
		Light,
		[EnumMember(Value = "dark")]
		Dark,
		[EnumMember(Value = "no-preference")]
		NoPreference,
	}
}