using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public static class EffectAreaExtensions
	{
		private static readonly Rect rectForCharacter;

		private static readonly Vector2[] splitedCharacterPosition;

		public static Rect GetEffectArea(this EffectArea area, VertexHelper vh, Rect rectangle, float aspectRatio = -1f)
		{
			return default(Rect);
		}

		public static void GetPositionFactor(this EffectArea area, int index, Rect rect, Vector2 position, bool isText, bool isTMPro, out float x, out float y)
		{
			x = default(float);
			y = default(float);
		}

		public static void GetNormalizedFactor(this EffectArea area, int index, Matrix2x3 matrix, Vector2 position, bool isText, out Vector2 nomalizedPos)
		{
			nomalizedPos = default(Vector2);
		}
	}
}
