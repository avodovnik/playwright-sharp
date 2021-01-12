
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum ElementHandleButtonEnum 
    {
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "right")]
		Right,
		[EnumMember(Value = "middle")]
		Middle,
	}
}