using UnityEngine;
using com.adjust.sdk;

public class ExampleGUI : MonoBehaviour
{
	private int numberOfButtons;

	private bool isEnabled;

	private bool showPopUp;

	private string txtSetEnabled;

	private string txtManualLaunch;

	private string txtSetOfflineMode;

	private void OnGUI()
	{
	}

	private void ShowGUI(int windowID)
	{
	}

	public void HandleGooglePlayId(string adId)
	{
	}

	public void AttributionChangedCallback(AdjustAttribution attributionData)
	{
	}

	public void EventSuccessCallback(AdjustEventSuccess eventSuccessData)
	{
	}

	public void EventFailureCallback(AdjustEventFailure eventFailureData)
	{
	}

	public void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData)
	{
	}

	public void SessionFailureCallback(AdjustSessionFailure sessionFailureData)
	{
	}

	private void DeferredDeeplinkCallback(string deeplinkURL)
	{
	}
}
