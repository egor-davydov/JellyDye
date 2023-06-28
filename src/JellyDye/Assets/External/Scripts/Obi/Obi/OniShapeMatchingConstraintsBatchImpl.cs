namespace Obi
{
	public class OniShapeMatchingConstraintsBatchImpl : OniConstraintsBatchImpl, IShapeMatchingConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniShapeMatchingConstraintsBatchImpl(OniShapeMatchingConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetShapeMatchingConstraints(ObiNativeIntList particleIndices, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, ObiNativeIntList explicitGroup, ObiNativeFloatList shapeMaterialParameters, ObiNativeVector4List restComs, ObiNativeVector4List coms, ObiNativeQuaternionList orientations, ObiNativeFloatList lambdas, int count)
		{
		}

		public void CalculateRestShapeMatching()
		{
		}
	}
}
