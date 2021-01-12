
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum FrameStateEnum 
    {
		[EnumMember(Value = "attached")]
		Attached,
		[EnumMember(Value = "detached")]
		Detached,
		[EnumMember(Value = "visible")]
		Visible,
		[EnumMember(Value = "hidden")]
		Hidden,
	}
}