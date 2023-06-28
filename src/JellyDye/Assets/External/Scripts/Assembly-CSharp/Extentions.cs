using UnityEngine;
using UnityEngine.UI;

public static class Extentions
{
	private static Vector3[] corners;

	public static Bounds TransformBoundsTo(this RectTransform source, Transform target)
	{
		return default(Bounds);
	}

	public static float NormalizeScrollDistance(this ScrollRect scrollRect, int axis, float distance)
	{
		return 0f;
	}
}
