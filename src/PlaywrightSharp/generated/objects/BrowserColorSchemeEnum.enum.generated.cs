
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum BrowserColorSchemeEnum 
    {
		[EnumMember(Value = "dark")]
		Dark,
		[EnumMember(Value = "light")]
		Light,
		[EnumMember(Value = "no-preference")]
		NoPreference,
	}
}