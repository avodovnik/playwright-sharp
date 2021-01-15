
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum VEnum 
    {
		[EnumMember(Value = "null")]
		Null,
		[EnumMember(Value = "undefined")]
		Undefined,
		[EnumMember(Value = "NaN")]
		NotANumber,
		[EnumMember(Value = "Infinity")]
		PositiveInfinity,
		[EnumMember(Value = "-Infinity")]
		NegativeInfinity,
		[EnumMember(Value = "-0")]
		NegativeZero,
	}
}