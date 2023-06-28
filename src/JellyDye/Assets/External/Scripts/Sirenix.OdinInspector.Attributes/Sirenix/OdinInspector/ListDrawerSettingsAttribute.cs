using System;

namespace Sirenix.OdinInspector
{
	public sealed class ListDrawerSettingsAttribute : Attribute
	{
		public bool HideAddButton;

		public bool HideRemoveButton;

		public string ListElementLabelName;

		public string CustomAddFunction;

		public string CustomRemoveIndexFunction;

		public string CustomRemoveElementFunction;

		public string OnBeginListElementGUI;

		public string OnEndListElementGUI;

		public bool AlwaysAddDefaultValue;

		public bool AddCopiesLastElement;

		private string onTitleBarGUI;

		private int numberOfItemsPerPage;

		private bool paging;

		private bool draggable;

		private bool isReadOnly;

		private bool showItemCount;

		private bool pagingHasValue;

		private bool draggableHasValue;

		private bool isReadOnlyHasValue;

		private bool showItemCountHasValue;

		private bool expanded;

		private bool expandedHasValue;

		private bool numberOfItemsPerPageHasValue;

		private bool showIndexLabels;

		private bool showIndexLabelsHasValue;

		public bool ShowPaging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DraggableItems
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int NumberOfItemsPerPage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowItemCount
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Expanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowIndexLabels
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string OnTitleBarGUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool PagingHasValue => false;

		public bool ShowItemCountHasValue => false;

		public bool NumberOfItemsPerPageHasValue => false;

		public bool DraggableHasValue => false;

		public bool IsReadOnlyHasValue => false;

		public bool ExpandedHasValue => false;

		public bool ShowIndexLabelsHasValue => false;
	}
}
