namespace Obi
{
	public class OniStitchConstraintsBatchImpl : OniConstraintsBatchImpl, IStitchConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniStitchConstraintsBatchImpl(OniStitchConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetStitchConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
