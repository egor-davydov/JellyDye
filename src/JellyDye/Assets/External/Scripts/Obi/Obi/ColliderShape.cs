using UnityEngine;

namespace Obi
{
	public struct ColliderShape
	{
		public enum ShapeType
		{
			Sphere = 0,
			Box = 1,
			Capsule = 2,
			Heightmap = 3,
			TriangleMesh = 4,
			EdgeMesh = 5,
			SignedDistanceField = 6
		}

		public Vector4 center;

		public Vector4 size;

		public ShapeType type;

		public float contactOffset;

		public int dataIndex;

		public int rigidbodyIndex;

		public int materialIndex;

		public int phase;

		public int flags;

		public int is2D;
	}
}
