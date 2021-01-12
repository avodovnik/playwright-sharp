
using System;
using System.Runtime.Serialization;

namespace PlaywrightSharp.Models
{
    internal enum CheckedEnum 
    {
		[EnumMember(Value = "checked")]
		Checked,
		[EnumMember(Value = "unchecked")]
		Unchecked,
		[EnumMember(Value = "mixed")]
		Mixed,
	}
}