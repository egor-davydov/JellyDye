using System;

namespace Obi
{
	[Serializable]
	public class ObiShapeMatchingConstraintsData : ObiConstraints<ObiShapeMatchingConstraintsBatch>
	{
		public override ObiShapeMatchingConstraintsBatch CreateBatch(ObiShapeMatchingConstraintsBatch source = null)
		{
			return null;
		}

		public ObiShapeMatchingConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
