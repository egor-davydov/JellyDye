using System;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiNativeQuaternionList : ObiNativeList<Quaternion>
	{
		public ObiNativeQuaternionList(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}

		public ObiNativeQuaternionList(int capacity, int alignment, Quaternion defaultValue)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
