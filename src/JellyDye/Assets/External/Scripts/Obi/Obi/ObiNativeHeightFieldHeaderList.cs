using System;

namespace Obi
{
	[Serializable]
	public class ObiNativeHeightFieldHeaderList : ObiNativeList<HeightFieldHeader>
	{
		public ObiNativeHeightFieldHeaderList(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
