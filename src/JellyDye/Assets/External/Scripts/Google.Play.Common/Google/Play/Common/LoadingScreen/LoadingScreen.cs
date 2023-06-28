using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Google.Play.Common.LoadingScreen
{
	public class LoadingScreen : MonoBehaviour
	{
		public string AssetBundleUrl;

		public LoadingBar LoadingBar;

		public Button RetryButton;

		private const int InitialAttemptCount = 3;

		private AssetBundle _bundle;

		private int _assetBundleRetrievalAttemptCount;

		private float _maxLoadingBarProgress;

		private bool _downloading;

		private void Start()
		{
		}

		public void ButtonEventRetryDownload()
		{
		}

		private void AttemptAssetBundleDownload(int numberOfAttempts)
		{
		}

		private IEnumerator AttemptAssetBundleDownloadsCo(int numberOfAttempts)
		{
			return null;
		}

		private IEnumerator GetAssetBundle(string assetBundleUrl)
		{
			return null;
		}

		private void ShowRetryButton()
		{
		}

		private void HideRetryButton()
		{
		}

		private static bool IsNetworkError(UnityWebRequest request)
		{
			return false;
		}

		private static AsyncOperation StartAssetBundleDownload(string assetBundleUrl, out UnityWebRequest webRequest)
		{
			webRequest = null;
			return null;
		}
	}
}
