namespace Obi
{
	public class OniBendTwistConstraintsBatchImpl : OniConstraintsBatchImpl, IBendTwistConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniBendTwistConstraintsBatchImpl(OniBendTwistConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetBendTwistConstraints(ObiNativeIntList orientationIndices, ObiNativeQuaternionList restOrientations, ObiNativeVector3List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
