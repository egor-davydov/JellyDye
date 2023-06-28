namespace Obi
{
	public class OniDistanceConstraintsImpl : OniConstraintsImpl
	{
		public OniDistanceConstraintsImpl(OniSolverImpl solver)
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
