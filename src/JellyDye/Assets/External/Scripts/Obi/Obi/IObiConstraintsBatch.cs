using System.Collections.Generic;

namespace Obi
{
	public interface IObiConstraintsBatch
	{
		int constraintCount { get; }

		int activeConstraintCount { get; set; }

		int initialActiveConstraintCount { get; set; }

		Oni.ConstraintType constraintType { get; }

		IConstraintsBatchImpl implementation { get; }

		void AddToSolver(ObiSolver solver);

		void RemoveFromSolver(ObiSolver solver);

		void Merge(ObiActor actor, IObiConstraintsBatch other);

		bool DeactivateConstraint(int constraintIndex);

		bool ActivateConstraint(int constraintIndex);

		void DeactivateAllConstraints();

		void Clear();

		void GetParticlesInvolved(int index, List<int> particles);

		void ParticlesSwapped(int index, int newIndex);
	}
}
