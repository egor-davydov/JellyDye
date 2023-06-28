using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class CatalogResult : ResultBase, ICatalogResult, IResult
	{
		public IList<Product> Products
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

		public CatalogResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
