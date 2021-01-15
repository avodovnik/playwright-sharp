
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum PressedEnum 
    {
		[EnumMember(Value = "pressed")]
		Pressed,
		[EnumMember(Value = "released")]
		Released,
		[EnumMember(Value = "mixed")]
		Mixed,
	}
}