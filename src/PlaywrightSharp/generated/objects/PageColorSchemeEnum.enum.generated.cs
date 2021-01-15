
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum PageColorSchemeEnum 
    {
		[EnumMember(Value = "dark")]
		Dark,
		[EnumMember(Value = "light")]
		Light,
		[EnumMember(Value = "no-preference")]
		NoPreference,
		[EnumMember(Value = "null")]
		Null,
	}
}