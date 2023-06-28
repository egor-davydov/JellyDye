using System;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiNativeVector3List : ObiNativeList<Vector3>
	{
		public ObiNativeVector3List(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
