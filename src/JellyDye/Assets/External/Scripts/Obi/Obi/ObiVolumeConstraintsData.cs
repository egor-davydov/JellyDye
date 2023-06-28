using System;

namespace Obi
{
	[Serializable]
	public class ObiVolumeConstraintsData : ObiConstraints<ObiVolumeConstraintsBatch>
	{
		public override ObiVolumeConstraintsBatch CreateBatch(ObiVolumeConstraintsBatch source = null)
		{
			return null;
		}

		public ObiVolumeConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
