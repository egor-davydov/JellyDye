namespace Obi
{
	public abstract class OniConstraintsImpl : IOniConstraintsImpl, IConstraints
	{
		protected OniSolverImpl m_Solver;

		protected Oni.ConstraintType m_ConstraintType;

		public ISolverImpl solver => null;

		public Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public OniConstraintsImpl(OniSolverImpl solver, Oni.ConstraintType constraintType)
		{
		}

		public abstract IConstraintsBatchImpl CreateConstraintsBatch();

		public abstract void RemoveBatch(IConstraintsBatchImpl batch);

		public int GetConstraintCount()
		{
			return 0;
		}
	}
}
