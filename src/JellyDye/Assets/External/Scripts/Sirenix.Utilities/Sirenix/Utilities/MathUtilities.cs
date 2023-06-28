using UnityEngine;

namespace Sirenix.Utilities
{
	public static class MathUtilities
	{
		private const float ZERO_TOLERANCE = 1E-06f;

		public static float PointDistanceToLine(Vector3 point, Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public static float Hermite(float start, float end, float t)
		{
			return 0f;
		}

		public static float StackHermite(float start, float end, float t, int count)
		{
			return 0f;
		}

		public static float Fract(float value)
		{
			return 0f;
		}

		public static Vector2 Fract(Vector2 value)
		{
			return default(Vector2);
		}

		public static Vector3 Fract(Vector3 value)
		{
			return default(Vector3);
		}

		public static float BounceEaseInFastOut(float t)
		{
			return 0f;
		}

		public static float Hermite01(float t)
		{
			return 0f;
		}

		public static float StackHermite01(float t, int count)
		{
			return 0f;
		}

		public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float amount)
		{
			return default(Vector3);
		}

		public static Vector2 LerpUnclamped(Vector2 from, Vector2 to, float amount)
		{
			return default(Vector2);
		}

		public static float Bounce(float value)
		{
			return 0f;
		}

		public static float EaseInElastic(float value, float amplitude = 0.25f, float length = 0.6f)
		{
			return 0f;
		}

		public static Vector3 Pow(this Vector3 v, float p)
		{
			return default(Vector3);
		}

		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		public static Vector3 Sign(this Vector3 v)
		{
			return default(Vector3);
		}

		public static float EaseOutElastic(float value, float amplitude = 0.25f, float length = 0.6f)
		{
			return 0f;
		}

		public static float EaseInOut(float t)
		{
			return 0f;
		}

		public static Vector3 Clamp(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(Vector3);
		}

		public static Vector2 Clamp(this Vector2 value, Vector2 min, Vector2 max)
		{
			return default(Vector2);
		}

		public static int ComputeByteArrayHash(byte[] data)
		{
			return 0;
		}

		public static Vector3 InterpolatePoints(Vector3[] path, float t)
		{
			return default(Vector3);
		}

		public static bool LineIntersectsLine(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2, out Vector2 intersection)
		{
			intersection = default(Vector2);
			return false;
		}

		public static Vector2 InfiniteLineIntersect(Vector2 ps1, Vector2 pe1, Vector2 ps2, Vector2 pe2)
		{
			return default(Vector2);
		}

		public static float LineDistToPlane(Vector3 planeOrigin, Vector3 planeNormal, Vector3 lineOrigin, Vector3 lineDirectionNormalized)
		{
			return 0f;
		}

		public static float RayDistToPlane(Ray ray, Plane plane)
		{
			return 0f;
		}

		public static Vector2 RotatePoint(Vector2 point, float degrees)
		{
			return default(Vector2);
		}

		public static Vector2 RotatePoint(Vector2 point, Vector2 around, float degrees)
		{
			return default(Vector2);
		}

		public static float SmoothStep(float a, float b, float t)
		{
			return 0f;
		}

		public static float LinearStep(float a, float b, float t)
		{
			return 0f;
		}

		public static double Wrap(double value, double min, double max)
		{
			return 0.0;
		}

		public static float Wrap(float value, float min, float max)
		{
			return 0f;
		}

		public static int Wrap(int value, int min, int max)
		{
			return 0;
		}

		public static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
		{
			return 0.0;
		}

		public static double DiscardLeastSignificantDecimal(double v)
		{
			return 0.0;
		}

		public static float ClampWrapAngle(float angle, float min, float max)
		{
			return 0f;
		}

		private static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
		{
			return 0;
		}
	}
}
