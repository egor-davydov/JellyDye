using UnityEngine;

namespace Obi
{
	public struct AffineTransform
	{
		public Vector4 translation;

		public Vector4 scale;

		public Quaternion rotation;

		public AffineTransform(Vector4 translation, Quaternion rotation, Vector4 scale)
		{
		}

		public void FromTransform(Transform source, bool is2D = false)
		{
		}
	}
}
