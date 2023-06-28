namespace Obi
{
	public interface IObiConstraints
	{
		Oni.ConstraintType? GetConstraintType();

		IObiConstraintsBatch GetBatch(int i);

		int GetBatchCount();

		void Clear();

		bool AddToSolver(ObiSolver solver);

		bool RemoveFromSolver();

		int GetConstraintCount();

		int GetActiveConstraintCount();

		void DeactivateAllConstraints();

		void Merge(ObiActor actor, IObiConstraints other);
	}
}
