using System;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiNativeVector2List : ObiNativeList<Vector2>
	{
		public ObiNativeVector2List(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}
	}
}
