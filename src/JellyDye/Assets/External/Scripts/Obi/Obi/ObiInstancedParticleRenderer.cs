using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiInstancedParticleRenderer : MonoBehaviour
	{
		private static ProfilerMarker m_DrawParticlesPerfMarker;

		public bool render;

		public Mesh mesh;

		public Material material;

		public Vector3 instanceScale;

		private List<Matrix4x4> matrices;

		private List<Vector4> colors;

		private MaterialPropertyBlock mpb;

		private int meshesPerBatch;

		private int batchCount;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void DrawParticles(ObiActor actor)
		{
		}
	}
}
