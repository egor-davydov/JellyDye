using System;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	public class TableListAttribute : Attribute
	{
		public int NumberOfItemsPerPage;

		public bool IsReadOnly;

		public int DefaultMinColumnWidth;

		public bool ShowIndexLabels;

		public bool DrawScrollView;

		public int MinScrollViewHeight;

		public int MaxScrollViewHeight;

		public bool AlwaysExpanded;

		public bool HideToolbar;

		public int CellPadding;

		[SerializeField]
		[HideInInspector]
		private bool showPagingHasValue;

		[HideInInspector]
		[SerializeField]
		private bool showPaging;

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

		public bool ShowPagingHasValue => false;

		public int ScrollViewHeight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
