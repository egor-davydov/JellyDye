using System;

namespace Obi
{
	[Serializable]
	public class ObiAerodynamicConstraintsData : ObiConstraints<ObiAerodynamicConstraintsBatch>
	{
		public override ObiAerodynamicConstraintsBatch CreateBatch(ObiAerodynamicConstraintsBatch source = null)
		{
			return null;
		}

		public ObiAerodynamicConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
