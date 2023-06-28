using System;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public struct DFNode
	{
		public Vector4 distancesA;

		public Vector4 distancesB;

		public Vector4 center;

		public int firstChild;

		private int pad0;

		private int pad1;

		private int pad2;

		public DFNode(Vector4 center)
		{
		}

		public float Sample(Vector3 position)
		{
			return 0f;
		}

		public Vector3 GetNormalizedPos(Vector3 position)
		{
			return default(Vector3);
		}

		public int GetOctant(Vector3 position)
		{
			return 0;
		}
	}
}
