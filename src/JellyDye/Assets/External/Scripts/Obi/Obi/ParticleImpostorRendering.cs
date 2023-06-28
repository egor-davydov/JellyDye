using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	public class ParticleImpostorRendering
	{
		private static ProfilerMarker m_ParticlesToMeshPerfMarker;

		private List<Mesh> meshes;

		private List<Vector3> vertices;

		private List<Vector3> normals;

		private List<Color> colors;

		private List<int> triangles;

		private List<Vector4> anisotropy1;

		private List<Vector4> anisotropy2;

		private List<Vector4> anisotropy3;

		private int particlesPerDrawcall;

		private int drawcallCount;

		private Vector3 particleOffset0;

		private Vector3 particleOffset1;

		private Vector3 particleOffset2;

		private Vector3 particleOffset3;

		public IEnumerable<Mesh> Meshes => null;

		private void Apply(Mesh mesh)
		{
		}

		public void ClearMeshes()
		{
		}

		public void UpdateMeshes(IObiParticleCollection collection)
		{
		}
	}
}
