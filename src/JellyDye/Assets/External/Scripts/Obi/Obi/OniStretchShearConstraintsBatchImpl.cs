namespace Obi
{
	public class OniStretchShearConstraintsBatchImpl : OniConstraintsBatchImpl, IStretchShearConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniStretchShearConstraintsBatchImpl(OniStretchShearConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetStretchShearConstraints(ObiNativeIntList particleIndices, ObiNativeIntList orientationIndices, ObiNativeFloatList restLengths, ObiNativeQuaternionList restOrientations, ObiNativeVector3List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
