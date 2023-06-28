using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class ValidateInputAttribute : Attribute
	{
		public string DefaultMessage;

		public string MemberName;

		public InfoMessageType MessageType;

		public bool IncludeChildren;

		public bool ContinuousValidationCheck;

		[Obsolete]
		public bool ContiniousValidationCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ValidateInputAttribute(string memberName, string defaultMessage = null, InfoMessageType messageType = InfoMessageType.Error)
		{
		}

		[Obsolete]
		public ValidateInputAttribute(string memberName, string message, InfoMessageType messageType, bool rejectedInvalidInput)
		{
		}
	}
}
