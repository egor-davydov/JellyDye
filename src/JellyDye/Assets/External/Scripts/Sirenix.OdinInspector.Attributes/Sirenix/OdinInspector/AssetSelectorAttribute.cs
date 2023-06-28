using System;

namespace Sirenix.OdinInspector
{
	public class AssetSelectorAttribute : Attribute
	{
		public bool IsUniqueList;

		public bool DrawDropdownForListElements;

		public bool DisableListAddButtonBehaviour;

		public bool ExcludeExistingValuesInList;

		public bool ExpandAllMenuItems;

		public bool FlattenTreeView;

		public int DropdownWidth;

		public int DropdownHeight;

		public string DropdownTitle;

		public string[] SearchInFolders;

		public string Filter;

		public string Paths
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
