using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiParticleRenderer : MonoBehaviour
	{
		private static ProfilerMarker m_DrawParticlesPerfMarker;

		public bool render;

		public Shader shader;

		public Color particleColor;

		public float radiusScale;

		private Material material;

		private ParticleImpostorRendering impostors;

		public IEnumerable<Mesh> ParticleMeshes => null;

		public Material ParticleMaterial => null;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void CreateMaterialIfNeeded()
		{
		}

		private void DrawParticles(ObiActor actor)
		{
		}

		private void DrawParticles()
		{
		}
	}
}
