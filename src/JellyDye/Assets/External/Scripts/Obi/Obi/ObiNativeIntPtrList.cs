using System;

namespace Obi
{
	public class ObiNativeIntPtrList : ObiNativeList<IntPtr>
	{
		public ObiNativeIntPtrList(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
