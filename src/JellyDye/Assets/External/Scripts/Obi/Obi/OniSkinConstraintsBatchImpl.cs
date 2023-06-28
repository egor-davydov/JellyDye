namespace Obi
{
	public class OniSkinConstraintsBatchImpl : OniConstraintsBatchImpl, ISkinConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniSkinConstraintsBatchImpl(OniSkinConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetSkinConstraints(ObiNativeIntList particleIndices, ObiNativeVector4List skinPoints, ObiNativeVector4List skinNormals, ObiNativeFloatList skinRadiiBackstop, ObiNativeFloatList skinCompliance, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
