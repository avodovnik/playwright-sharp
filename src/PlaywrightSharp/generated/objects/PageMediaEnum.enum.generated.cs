
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum PageMediaEnum 
    {
		[EnumMember(Value = "screen")]
		Screen,
		[EnumMember(Value = "print")]
		Print,
		[EnumMember(Value = "null")]
		Null,
	}
}