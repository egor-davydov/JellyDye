using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiParticleGroup : ScriptableObject
	{
		public List<int> particleIndices;

		public ObiActorBlueprint m_Blueprint;

		public ObiActorBlueprint blueprint => null;

		public int Count => 0;

		public void SetSourceBlueprint(ObiActorBlueprint blueprint)
		{
		}

		public bool ContainsParticle(int index)
		{
			return false;
		}
	}
}
