using System;

namespace Sirenix.OdinInspector
{
	public class TableMatrixAttribute : Attribute
	{
		public bool IsReadOnly;

		public bool ResizableColumns;

		public string VerticalTitle;

		public string HorizontalTitle;

		public string DrawElementMethod;

		public int RowHeight;

		public bool SquareCells;

		public bool HideColumnIndices;

		public bool HideRowIndices;

		public bool RespectIndentLevel;

		public bool Transpose;
	}
}
