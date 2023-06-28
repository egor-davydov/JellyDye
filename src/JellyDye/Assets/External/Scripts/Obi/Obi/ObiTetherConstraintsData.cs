using System;

namespace Obi
{
	[Serializable]
	public class ObiTetherConstraintsData : ObiConstraints<ObiTetherConstraintsBatch>
	{
		public override ObiTetherConstraintsBatch CreateBatch(ObiTetherConstraintsBatch source = null)
		{
			return null;
		}

		public ObiTetherConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
