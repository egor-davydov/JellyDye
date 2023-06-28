using System;
using System.Collections.Generic;
using UnityEngine.Purchasing;

public class PurchaseController : IStoreListener
{
	private static readonly IProduct NoAds;

	private static readonly IProduct VIP;

	private readonly List<IProduct> _products;

	private readonly List<IProductHandler> _handlers;

	private IStoreController _storeController;

	private IExtensionProvider _extensionProvider;

	private IAppleExtensions m_AppleExtensions;

	private Action<bool> _onPurchaseCompleted;

	~PurchaseController()
	{
	}

	private bool IsInitialized()
	{
		return false;
	}

	private void Initialize()
	{
	}

	private IProductHandler GetHandler(IProduct product)
	{
		return null;
	}

	private IProduct GetProduct(string productId)
	{
		return null;
	}

	public void BuyNoAds(Action<bool> onCompleted = null)
	{
	}

	public void BuyVIP(Action<bool> onCompleted = null)
	{
	}

	private void BuyProduct(string productId, Action<bool> onCompleted = null)
	{
	}

	public void RestorePurchases()
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs eventArgs)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason error)
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	private bool checkIfProductIsAvailableForSubscriptionManager(string receipt)
	{
		return false;
	}
}
