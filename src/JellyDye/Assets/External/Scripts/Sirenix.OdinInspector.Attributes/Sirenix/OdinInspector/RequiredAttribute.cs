using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class RequiredAttribute : Attribute
	{
		public string ErrorMessage;

		public InfoMessageType MessageType;

		public RequiredAttribute()
		{
		}

		public RequiredAttribute(string errorMessage, InfoMessageType messageType)
		{
		}

		public RequiredAttribute(string errorMessage)
		{
		}

		public RequiredAttribute(InfoMessageType messageType)
		{
		}
	}
}
