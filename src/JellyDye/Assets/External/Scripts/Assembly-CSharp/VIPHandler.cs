using System;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing;

public class VIPHandler : IProductHandler
{
	public Type ProductType
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

	public IProductHandler SetProduct<T>() where T : IProduct
	{
		return null;
	}

	public bool CanHandle(IProduct product)
	{
		return false;
	}

	public void AddProduct(IProduct product, ConfigurationBuilder builder)
	{
	}

	public void HandlePurchase(IProduct product)
	{
	}
}
