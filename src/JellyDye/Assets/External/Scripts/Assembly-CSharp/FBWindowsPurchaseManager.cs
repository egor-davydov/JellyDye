using System.Collections;
using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class FBWindowsPurchaseManager : MonoBehaviour
{
	public FBWindowsLogsManager Logger;

	public GameObject ProductGameObject;

	public Transform CatalogPanelTarnsform;

	public Transform PurchasesPanelTarnsform;

	public void GetCatalogButton()
	{
	}

	private void ProcessGetCatalog(ICatalogResult result)
	{
	}

	private IEnumerator LoadPictureFromUrl(string url, RawImage itemImage)
	{
		return null;
	}

	private void ProcessPurchase(IPurchaseResult result)
	{
	}

	public void GetPurchases()
	{
	}

	private void processPurchases(IPurchasesResult result)
	{
	}
}
