using UnityEngine;

namespace Obi
{
	public struct Aabb
	{
		public Vector4 min;

		public Vector4 max;

		public Vector4 center => default(Vector4);

		public Vector4 size => default(Vector4);

		public Aabb(Vector4 min, Vector4 max)
		{
		}

		public Aabb(Vector4 point)
		{
		}

		public void Encapsulate(Vector4 point)
		{
		}

		public void Encapsulate(Aabb other)
		{
		}

		public void FromBounds(Bounds bounds, float thickness, bool is2D = false)
		{
		}
	}
}
