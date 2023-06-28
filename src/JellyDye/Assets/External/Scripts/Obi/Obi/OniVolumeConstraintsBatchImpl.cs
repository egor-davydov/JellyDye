namespace Obi
{
	public class OniVolumeConstraintsBatchImpl : OniConstraintsBatchImpl, IVolumeConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniVolumeConstraintsBatchImpl(OniVolumeConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetVolumeConstraints(ObiNativeIntList triangles, ObiNativeIntList firstTriangle, ObiNativeIntList numTriangles, ObiNativeFloatList restVolumes, ObiNativeVector2List pressureStiffness, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
