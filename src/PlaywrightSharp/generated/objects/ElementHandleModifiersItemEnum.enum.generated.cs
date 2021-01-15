
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum ElementHandleModifiersItemEnum 
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