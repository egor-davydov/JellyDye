using System;

namespace Obi
{
	[Serializable]
	public class ObiBendConstraintsData : ObiConstraints<ObiBendConstraintsBatch>
	{
		public override ObiBendConstraintsBatch CreateBatch(ObiBendConstraintsBatch source = null)
		{
			return null;
		}

		public ObiBendConstraintsData()
		{
			((ObiConstraints<>)(object)this)._002Ector();
		}
	}
}
