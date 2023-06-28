using System;

namespace Sirenix.OdinInspector
{
	public class TableColumnWidthAttribute : Attribute
	{
		public int Width;

		public bool Resizable;

		public TableColumnWidthAttribute(int width, bool resizable = true)
		{
		}
	}
}
