using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class DisableContextMenuAttribute : Attribute
	{
		public bool DisableForMember;

		public bool DisableForCollectionElements;

		public DisableContextMenuAttribute(bool disableForMember = true, bool disableCollectionElements = false)
		{
		}
	}
}
