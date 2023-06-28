using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiSkinConstraintsBatch : ObiConstraintsBatch
	{
		protected ISkinConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeVector4List skinPoints;

		[HideInInspector]
		public ObiNativeVector4List skinNormals;

		[HideInInspector]
		public ObiNativeFloatList skinRadiiBackstop;

		[HideInInspector]
		public ObiNativeFloatList skinCompliance;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiSkinConstraintsBatch(ObiSkinConstraintsData constraints = null)
		{
		}

		public void AddConstraint(int index, Vector4 point, Vector4 normal, float radius, float collisionRadius, float backstop, float stiffness)
		{
		}

		public override void Clear()
		{
		}

		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		public override void AddToSolver(ObiSolver solver)
		{
		}

		public override void RemoveFromSolver(ObiSolver solver)
		{
		}
	}
}
