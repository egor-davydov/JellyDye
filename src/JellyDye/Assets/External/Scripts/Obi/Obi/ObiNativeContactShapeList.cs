using System;

namespace Obi
{
	[Serializable]
	public class ObiNativeContactShapeList : ObiNativeList<Oni.Contact>
	{
		public ObiNativeContactShapeList(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
