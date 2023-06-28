using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class PurchasesResult : ResultBase, IPurchasesResult, IResult
	{
		public IList<Purchase> Purchases
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

		public PurchasesResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
