
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum FrameModifiersItemEnum 
    {
		[EnumMember(Value = "Alt")]
		Alt,
		[EnumMember(Value = "Control")]
		Control,
		[EnumMember(Value = "Meta")]
		Meta,
		[EnumMember(Value = "Shift")]
		Shift,
	}
}