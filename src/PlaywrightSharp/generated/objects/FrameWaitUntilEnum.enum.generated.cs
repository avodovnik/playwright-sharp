
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum FrameWaitUntilEnum 
    {
		[EnumMember(Value = "load")]
		Load,
		[EnumMember(Value = "domcontentloaded")]
		Domcontentloaded,
		[EnumMember(Value = "networkidle")]
		Networkidle,
	}
}