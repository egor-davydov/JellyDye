using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public static class ObiUtils
	{
		public static readonly Color32[] colorAlphabet;

		public static void DrawArrowGizmo(float bodyLenght, float bodyWidth, float headLenght, float headWidth)
		{
		}

		public static void DebugDrawCross(Vector3 pos, float size, Color color)
		{
		}

		public static void Swap<T>(ref T lhs, ref T rhs)
		{
		}

		public static void Swap<T>(this T[] source, int index1, int index2)
		{
		}

		public static void Swap<T>(this IList<T> list, int index1, int index2)
		{
		}

		public static void ShiftLeft<T>(this T[] source, int index, int count, int positions)
		{
		}

		public static void ShiftRight<T>(this T[] source, int index, int count, int positions)
		{
		}

		public static bool AreValid(this Bounds bounds)
		{
			return false;
		}

		public static Bounds Transform(this Bounds b, Matrix4x4 m)
		{
			return default(Bounds);
		}

		public static void Add(Vector3 a, Vector3 b, ref Vector3 result)
		{
		}

		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return 0f;
		}

		public static float Mod(float a, float b)
		{
			return 0f;
		}

		public static Matrix4x4 Add(this Matrix4x4 a, Matrix4x4 other)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 ScalarMultiply(this Matrix4x4 a, float s)
		{
			return default(Matrix4x4);
		}

		public static Vector3 ProjectPointLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd, out float mu, bool clampToSegment = true)
		{
			mu = default(float);
			return default(Vector3);
		}

		public static bool LinePlaneIntersection(Vector3 planePoint, Vector3 planeNormal, Vector3 linePoint, Vector3 lineDirection, out Vector3 point)
		{
			point = default(Vector3);
			return false;
		}

		public static float InvMassToMass(float invMass)
		{
			return 0f;
		}

		public static float MassToInvMass(float mass)
		{
			return 0f;
		}

		public static int PureSign(this float val)
		{
			return 0;
		}

		public static void NearestPointOnTri(in Vector3 p1, in Vector3 p2, in Vector3 p3, in Vector3 p, out Vector3 result)
		{
			result = default(Vector3);
		}

		public static float TriangleArea(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return 0f;
		}

		public static float EllipsoidVolume(Vector3 principalRadii)
		{
			return 0f;
		}

		public static Quaternion RestDarboux(Quaternion q1, Quaternion q2)
		{
			return default(Quaternion);
		}

		public static float RestBendingConstraint(Vector3 positionA, Vector3 positionB, Vector3 positionC)
		{
			return 0f;
		}

		public static IEnumerable BilateralInterleaved(int count)
		{
			return null;
		}

		public static void BarycentricCoordinates(in Vector3 A, in Vector3 B, in Vector3 C, in Vector3 P, ref Vector3 bary)
		{
		}

		public static void BarycentricInterpolation(in Vector3 p1, in Vector3 p2, in Vector3 p3, in Vector3 coords, out Vector3 result)
		{
			result = default(Vector3);
		}

		public static float BarycentricInterpolation(float p1, float p2, float p3, Vector3 coords)
		{
			return 0f;
		}

		public static float BarycentricExtrapolationScale(Vector3 coords)
		{
			return 0f;
		}

		public static Vector3[] CalculateAngleWeightedNormals(Vector3[] vertices, int[] triangles)
		{
			return null;
		}

		public static int MakePhase(int group, Oni.ParticleFlags flags)
		{
			return 0;
		}

		public static int GetGroupFromPhase(int phase)
		{
			return 0;
		}

		public static int GetFlagsFromPhase(int phase)
		{
			return 0;
		}

		public static void EigenSolve(Matrix4x4 D, out Vector3 S, out Matrix4x4 V)
		{
			S = default(Vector3);
			V = default(Matrix4x4);
		}

		private static Vector3 unitOrthogonal(this Vector3 input)
		{
			return default(Vector3);
		}

		private static Vector3 EigenVector(Matrix4x4 D, float S)
		{
			return default(Vector3);
		}

		private static Vector3 EigenValues(Matrix4x4 D)
		{
			return default(Vector3);
		}

		public static Vector3 GetPointCloudCentroid(List<Vector3> points)
		{
			return default(Vector3);
		}

		public static void GetPointCloudAnisotropy(List<Vector3> points, float max_anisotropy, float radius, ref Vector3 hint_normal, ref Vector3 centroid, ref Quaternion orientation, ref Vector3 principal_radii)
		{
		}
	}
}
