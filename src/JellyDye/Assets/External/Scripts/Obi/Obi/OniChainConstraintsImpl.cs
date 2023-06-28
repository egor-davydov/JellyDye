namespace Obi
{
	public class OniChainConstraintsImpl : OniConstraintsImpl
	{
		public OniChainConstraintsImpl(OniSolverImpl solver)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
