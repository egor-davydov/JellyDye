using UnityEngine;

namespace Obi
{
	public struct Triangle : IBounded
	{
		public int i1;

		public int i2;

		public int i3;

		private Aabb b;

		public Triangle(int i1, int i2, int i3, Vector3 v1, Vector3 v2, Vector3 v3)
		{
		}

		public Aabb GetBounds()
		{
			return default(Aabb);
		}
	}
}
