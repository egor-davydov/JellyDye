using System;

namespace Obi
{
	[Serializable]
	public class ObiBendTwistConstraintsData : ObiConstraints<ObiBendTwistConstraintsBatch>
	{
		public override ObiBendTwistConstraintsBatch CreateBatch(ObiBendTwistConstraintsBatch source = null)
		{
			return null;
		}

		public ObiBendTwistConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
