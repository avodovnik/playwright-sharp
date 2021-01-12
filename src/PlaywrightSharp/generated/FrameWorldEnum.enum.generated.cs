
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum FrameWorldEnum 
    {
		[EnumMember(Value = "main")]
		Main,
		[EnumMember(Value = "utility")]
		Utility,
	}
}