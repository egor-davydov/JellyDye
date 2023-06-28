using System.Collections.Generic;

namespace Facebook.Unity
{
	public interface IPurchasesResult : IResult
	{
		IList<Purchase> Purchases { get; }
	}
}
