using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class UnityEqualityComparer
	{
		private static class Cache<T>
		{
			public static readonly IEqualityComparer<T> Comparer;

			static Cache()
			{
			}
		}

		private sealed class Vector2EqualityComparer : IEqualityComparer<Vector2>
		{
			public bool Equals(Vector2 self, Vector2 vector)
			{
				return false;
			}

			public int GetHashCode(Vector2 obj)
			{
				return 0;
			}
		}

		private sealed class Vector3EqualityComparer : IEqualityComparer<Vector3>
		{
			public bool Equals(Vector3 self, Vector3 vector)
			{
				return false;
			}

			public int GetHashCode(Vector3 obj)
			{
				return 0;
			}
		}

		private sealed class Vector4EqualityComparer : IEqualityComparer<Vector4>
		{
			public bool Equals(Vector4 self, Vector4 vector)
			{
				return false;
			}

			public int GetHashCode(Vector4 obj)
			{
				return 0;
			}
		}

		private sealed class ColorEqualityComparer : IEqualityComparer<Color>
		{
			public bool Equals(Color self, Color other)
			{
				return false;
			}

			public int GetHashCode(Color obj)
			{
				return 0;
			}
		}

		private sealed class RectEqualityComparer : IEqualityComparer<Rect>
		{
			public bool Equals(Rect self, Rect other)
			{
				return false;
			}

			public int GetHashCode(Rect obj)
			{
				return 0;
			}
		}

		private sealed class BoundsEqualityComparer : IEqualityComparer<Bounds>
		{
			public bool Equals(Bounds self, Bounds vector)
			{
				return false;
			}

			public int GetHashCode(Bounds obj)
			{
				return 0;
			}
		}

		private sealed class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
		{
			public bool Equals(Quaternion self, Quaternion vector)
			{
				return false;
			}

			public int GetHashCode(Quaternion obj)
			{
				return 0;
			}
		}

		private sealed class Color32EqualityComparer : IEqualityComparer<Color32>
		{
			public bool Equals(Color32 self, Color32 vector)
			{
				return false;
			}

			public int GetHashCode(Color32 obj)
			{
				return 0;
			}
		}

		private sealed class Vector2IntEqualityComparer : IEqualityComparer<Vector2Int>
		{
			public bool Equals(Vector2Int self, Vector2Int vector)
			{
				return false;
			}

			public int GetHashCode(Vector2Int obj)
			{
				return 0;
			}
		}

		private sealed class Vector3IntEqualityComparer : IEqualityComparer<Vector3Int>
		{
			public static readonly Vector3IntEqualityComparer Default;

			public bool Equals(Vector3Int self, Vector3Int vector)
			{
				return false;
			}

			public int GetHashCode(Vector3Int obj)
			{
				return 0;
			}
		}

		private sealed class RangeIntEqualityComparer : IEqualityComparer<RangeInt>
		{
			public bool Equals(RangeInt self, RangeInt vector)
			{
				return false;
			}

			public int GetHashCode(RangeInt obj)
			{
				return 0;
			}
		}

		private sealed class RectIntEqualityComparer : IEqualityComparer<RectInt>
		{
			public bool Equals(RectInt self, RectInt other)
			{
				return false;
			}

			public int GetHashCode(RectInt obj)
			{
				return 0;
			}
		}

		private sealed class BoundsIntEqualityComparer : IEqualityComparer<BoundsInt>
		{
			public bool Equals(BoundsInt self, BoundsInt vector)
			{
				return false;
			}

			public int GetHashCode(BoundsInt obj)
			{
				return 0;
			}
		}

		public static readonly IEqualityComparer<Vector2> Vector2;

		public static readonly IEqualityComparer<Vector3> Vector3;

		public static readonly IEqualityComparer<Vector4> Vector4;

		public static readonly IEqualityComparer<Color> Color;

		public static readonly IEqualityComparer<Color32> Color32;

		public static readonly IEqualityComparer<Rect> Rect;

		public static readonly IEqualityComparer<Bounds> Bounds;

		public static readonly IEqualityComparer<Quaternion> Quaternion;

		private static readonly RuntimeTypeHandle vector2Type;

		private static readonly RuntimeTypeHandle vector3Type;

		private static readonly RuntimeTypeHandle vector4Type;

		private static readonly RuntimeTypeHandle colorType;

		private static readonly RuntimeTypeHandle color32Type;

		private static readonly RuntimeTypeHandle rectType;

		private static readonly RuntimeTypeHandle boundsType;

		private static readonly RuntimeTypeHandle quaternionType;

		public static readonly IEqualityComparer<Vector2Int> Vector2Int;

		public static readonly IEqualityComparer<Vector3Int> Vector3Int;

		public static readonly IEqualityComparer<RangeInt> RangeInt;

		public static readonly IEqualityComparer<RectInt> RectInt;

		public static readonly IEqualityComparer<BoundsInt> BoundsInt;

		private static readonly RuntimeTypeHandle vector2IntType;

		private static readonly RuntimeTypeHandle vector3IntType;

		private static readonly RuntimeTypeHandle rangeIntType;

		private static readonly RuntimeTypeHandle rectIntType;

		private static readonly RuntimeTypeHandle boundsIntType;

		public static IEqualityComparer<T> GetDefault<T>()
		{
			return null;
		}

		private static object GetDefaultHelper(Type type)
		{
			return null;
		}
	}
}
