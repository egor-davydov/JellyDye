using UnityEngine;

namespace Sirenix.Utilities
{
	public static class ColorExtensions
	{
		private static readonly char[] trimRGBStart;

		public static Color Lerp(this Color[] colors, float t)
		{
			return default(Color);
		}

		public static Color MoveTowards(this Color from, Color to, float maxDelta)
		{
			return default(Color);
		}

		public static bool TryParseString(string colorStr, out Color color)
		{
			color = default(Color);
			return false;
		}

		public static string ToCSharpColor(this Color color)
		{
			return null;
		}

		public static Color Pow(this Color color, float factor)
		{
			return default(Color);
		}

		public static Color NormalizeRGB(this Color color)
		{
			return default(Color);
		}

		private static string TrimFloat(float value)
		{
			return null;
		}
	}
}
