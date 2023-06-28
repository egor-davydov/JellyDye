using System;

namespace Obi
{
	[Serializable]
	public class ObiSkinConstraintsData : ObiConstraints<ObiSkinConstraintsBatch>
	{
		public override ObiSkinConstraintsBatch CreateBatch(ObiSkinConstraintsBatch source = null)
		{
			return null;
		}

		public ObiSkinConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
