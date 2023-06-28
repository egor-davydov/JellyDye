using System;
using System.Collections.Generic;

namespace Obi
{
	[Serializable]
	public class ObiShapeMatchingConstraintsBatch : ObiConstraintsBatch
	{
		protected IShapeMatchingConstraintsBatchImpl m_BatchImpl;

		public ObiNativeIntList firstIndex;

		public ObiNativeIntList numIndices;

		public ObiNativeIntList explicitGroup;

		public ObiNativeFloatList materialParameters;

		public ObiNativeVector4List restComs;

		public ObiNativeVector4List coms;

		public ObiNativeQuaternionList orientations;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiShapeMatchingConstraintsBatch(ObiShapeMatchingConstraintsData constraints = null)
		{
		}

		public void AddConstraint(int[] indices, bool isExplicit)
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

		public void RecalculateRestShapeMatching()
		{
		}
	}
}
