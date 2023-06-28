using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiStitcher : MonoBehaviour
	{
		[Serializable]
		public class Stitch
		{
			public int particleIndex1;

			public int particleIndex2;

			public Stitch(int particleIndex1, int particleIndex2)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private List<Stitch> stitches;

		[SerializeField]
		[HideInInspector]
		private ObiActor actor1;

		[SerializeField]
		[HideInInspector]
		private ObiActor actor2;

		[HideInInspector]
		public ObiNativeIntList particleIndices;

		[HideInInspector]
		public ObiNativeFloatList stiffnesses;

		[HideInInspector]
		public ObiNativeFloatList lambdas;

		private IStitchConstraintsBatchImpl m_BatchImpl;

		private bool inSolver;

		public ObiActor Actor1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObiActor Actor2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int StitchCount => 0;

		public IEnumerable<Stitch> Stitches => null;

		private void RegisterActor(ObiActor actor)
		{
		}

		private void UnregisterActor(ObiActor actor)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public int AddStitch(int particle1, int particle2)
		{
			return 0;
		}

		public void RemoveStitch(int index)
		{
		}

		public void Clear()
		{
		}

		private void Actor_OnBlueprintUnloaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		private void Actor_OnBlueprintLoaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		private void AddToSolver(ObiSolver solver)
		{
		}

		private void RemoveFromSolver(ObiSolver solver)
		{
		}

		public void PushDataToSolver()
		{
		}
	}
}
