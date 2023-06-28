using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public class ASDF
	{
		private static readonly Vector4[] corners;

		private static readonly Vector4[] samples;

		private const float sqrt3 = 1.73205f;

		public static IEnumerator Build(float maxError, int maxDepth, Vector3[] vertexPositions, int[] triangleIndices, List<DFNode> nodes, int yieldAfterNodeCount = 32)
		{
			return null;
		}

		public static float Sample(List<DFNode> nodes, Vector3 position)
		{
			return 0f;
		}
	}
}
