using UnityEngine.Purchasing;

public interface IProduct
{
	string ProductId { get; }

	ProductType ProductType { get; }
}
