using System.Collections.Generic;

namespace Facebook.Unity
{
	public interface ICatalogResult : IResult
	{
		IList<Product> Products { get; }
	}
}
