using System;

namespace Obi
{
	[Serializable]
	public class ObiNativeCellSpanList : ObiNativeList<CellSpan>
	{
		public ObiNativeCellSpanList(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
