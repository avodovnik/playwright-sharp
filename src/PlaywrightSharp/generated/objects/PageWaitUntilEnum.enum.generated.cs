
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum PageWaitUntilEnum 
    {
		[EnumMember(Value = "load")]
		Load,
		[EnumMember(Value = "domcontentloaded")]
		Domcontentloaded,
		[EnumMember(Value = "networkidle")]
		Networkidle,
	}
}