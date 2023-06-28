using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class InfoBoxAttribute : Attribute
	{
		public string Message;

		public InfoMessageType InfoMessageType;

		public string VisibleIf;

		public bool GUIAlwaysEnabled;

		public InfoBoxAttribute(string message, InfoMessageType infoMessageType = InfoMessageType.Info, string visibleIfMemberName = null)
		{
		}

		public InfoBoxAttribute(string message, string visibleIfMemberName)
		{
		}
	}
}
