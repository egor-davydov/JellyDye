using System.Runtime.CompilerServices;
using UnityEngine.Purchasing;

namespace Core.Purchase.Products
{
	public class NoAdsProduct : IProduct
	{
		public string ProductId
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

		public ProductType ProductType
		{
			[CompilerGenerated]
			get
			{
				return default(ProductType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public NoAdsProduct(string productId, ProductType productType)
		{
		}
	}
}
