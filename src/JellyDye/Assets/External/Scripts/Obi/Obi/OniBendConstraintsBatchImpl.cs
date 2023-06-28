namespace Obi
{
	public class OniBendConstraintsBatchImpl : OniConstraintsBatchImpl, IBendConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniBendConstraintsBatchImpl(OniBendConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetBendConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restBends, ObiNativeVector2List bendingStiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
