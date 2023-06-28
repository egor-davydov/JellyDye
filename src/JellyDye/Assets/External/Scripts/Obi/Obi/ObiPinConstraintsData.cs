using System;

namespace Obi
{
	[Serializable]
	public class ObiPinConstraintsData : ObiConstraints<ObiPinConstraintsBatch>
	{
		public override ObiPinConstraintsBatch CreateBatch(ObiPinConstraintsBatch source = null)
		{
			return null;
		}

		public ObiPinConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
