using UnityEngine;

namespace Coffee.UIExtensions
{
	public struct Matrix2x3
	{
		public float m00;

		public float m01;

		public float m02;

		public float m10;

		public float m11;

		public float m12;

		public Matrix2x3(Rect rect, float cos, float sin)
		{
		}

		public static Vector2 operator *(Matrix2x3 m, Vector2 v)
		{
			return default(Vector2);
		}
	}
}
