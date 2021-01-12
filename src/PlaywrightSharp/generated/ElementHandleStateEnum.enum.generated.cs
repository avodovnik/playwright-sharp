
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum ElementHandleStateEnum 
    {
		[EnumMember(Value = "visible")]
		Visible,
		[EnumMember(Value = "hidden")]
		Hidden,
		[EnumMember(Value = "stable")]
		Stable,
		[EnumMember(Value = "enabled")]
		Enabled,
		[EnumMember(Value = "disabled")]
		Disabled,
	}
}