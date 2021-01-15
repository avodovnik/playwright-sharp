
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum SameSiteEnum 
    {
		[EnumMember(Value = "Strict")]
		Strict,
		[EnumMember(Value = "Lax")]
		Lax,
		[EnumMember(Value = "None")]
		None,
	}
}