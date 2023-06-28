using System;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiNativeVector4List : ObiNativeList<Vector4>
	{
		public ObiNativeVector4List(int capacity = 8, int alignment = 16)
		{
			((ObiNativeList<>)(object)this)._002Ector(0, 0);
		}

		public Vector3 GetVector3(int index)
		{
			return default(Vector3);
		}

		public void SetVector3(int index, Vector3 value)
		{
		}
	}
}
