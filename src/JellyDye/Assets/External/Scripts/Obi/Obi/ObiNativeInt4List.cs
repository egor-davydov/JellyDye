using System;

namespace Obi
{
	[Serializable]
	public class ObiNativeInt4List : ObiNativeList<VInt4>
	{
		public ObiNativeInt4List(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}

		public ObiNativeInt4List(int capacity, int alignment, VInt4 defaultValue)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
