
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum PageTypeEnum 
    {
		[EnumMember(Value = "png")]
		Png,
		[EnumMember(Value = "jpeg")]
		Jpeg,
	}
}