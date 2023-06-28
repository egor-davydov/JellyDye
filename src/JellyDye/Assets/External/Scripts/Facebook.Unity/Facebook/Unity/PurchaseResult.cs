using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class PurchaseResult : ResultBase, IPurchaseResult, IResult
	{
		public Purchase Purchase
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PurchaseResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
