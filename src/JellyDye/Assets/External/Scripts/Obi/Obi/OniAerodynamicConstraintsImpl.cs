namespace Obi
{
	public class OniAerodynamicConstraintsImpl : OniConstraintsImpl
	{
		public OniAerodynamicConstraintsImpl(OniSolverImpl solver)
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
