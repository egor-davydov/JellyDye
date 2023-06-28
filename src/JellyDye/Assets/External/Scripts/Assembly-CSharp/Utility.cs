using System;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
	public static class ThreadSafeRandom
	{
		[ThreadStatic]
		private static System.Random Local;

		public static System.Random ThisThreadsRandom => null;
	}

	public static float RoundToN(this float value, float round)
	{
		return 0f;
	}

	public static Vector2 Rotate(this Vector2 v, float degrees)
	{
		return default(Vector2);
	}

	public static Vector3 SetZ(this Vector3 vector, float z)
	{
		return default(Vector3);
	}

	public static Vector3 SetY(this Vector3 vector, float y)
	{
		return default(Vector3);
	}

	public static Vector2 SetX(this Vector2 vector, float x)
	{
		return default(Vector2);
	}

	public static Vector2 SetY(this Vector2 vector, float y)
	{
		return default(Vector2);
	}

	public static Vector3 SetX(this Vector3 vector, float x)
	{
		return default(Vector3);
	}

	public static float GetRandomValue(this Vector2 vector)
	{
		return 0f;
	}

	public static void SetLeft(this RectTransform rt, float left)
	{
	}

	public static void SetRight(this RectTransform rt, float right)
	{
	}

	public static void SetTop(this RectTransform rt, float top)
	{
	}

	public static void SetBottom(this RectTransform rt, float bottom)
	{
	}

	public static T GetRandom<T>(this IList<T> list)
	{
		return default(T);
	}

	public static void SafeDestroy(this MonoBehaviour monoBehaviour)
	{
	}

	public static void DisableElements(this RectTransform element)
	{
	}

	public static void ScaleAround(GameObject target, Vector3 pivot, Vector3 newScale)
	{
	}

	public static void Shuffle<T>(this IList<T> list)
	{
	}

	public static void SwapItems<T>(this List<T> list, int idxX, int idxY)
	{
	}

	public static Color ChangeColorBrightness(this Color color, float correctionFactor)
	{
		return default(Color);
	}

	public static Texture2D toTexture2D(this RenderTexture rTex)
	{
		return null;
	}

	public static Color ChangeColorBrightness(this Color32 color, float correctionFactor)
	{
		return default(Color);
	}
}
