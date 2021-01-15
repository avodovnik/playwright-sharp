
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum ElementHandleTypeEnum 
    {
		[EnumMember(Value = "png")]
		Png,
		[EnumMember(Value = "jpeg")]
		Jpeg,
	}
}