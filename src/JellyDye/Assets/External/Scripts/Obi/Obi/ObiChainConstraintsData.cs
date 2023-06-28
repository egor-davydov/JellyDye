using System;

namespace Obi
{
	[Serializable]
	public class ObiChainConstraintsData : ObiConstraints<ObiChainConstraintsBatch>
	{
		public override ObiChainConstraintsBatch CreateBatch(ObiChainConstraintsBatch source = null)
		{
			return null;
		}

		public ObiChainConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
