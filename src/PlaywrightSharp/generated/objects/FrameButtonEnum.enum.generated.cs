
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum FrameButtonEnum 
    {
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "right")]
		Right,
		[EnumMember(Value = "middle")]
		Middle,
	}
}