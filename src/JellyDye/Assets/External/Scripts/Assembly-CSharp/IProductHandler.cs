using System;
using UnityEngine.Purchasing;

public interface IProductHandler
{
	Type ProductType { get; }

	IProductHandler SetProduct<T>() where T : IProduct;

	bool CanHandle(IProduct product);

	void AddProduct(IProduct product, ConfigurationBuilder builder);

	void HandlePurchase(IProduct product);
}
