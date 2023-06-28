using System;

namespace Obi
{
	[Serializable]
	public class ObiStretchShearConstraintsData : ObiConstraints<ObiStretchShearConstraintsBatch>
	{
		public override ObiStretchShearConstraintsBatch CreateBatch(ObiStretchShearConstraintsBatch source = null)
		{
			return null;
		}

		public ObiStretchShearConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
