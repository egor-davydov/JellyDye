using UnityEngine.SceneManagement;

namespace Facebook.Unity.Mobile.Android
{
	internal class AndroidFacebookGameObject : MobileFacebookGameObject
	{
		protected override void OnAwake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnDisable()
		{
		}

		public void onPurchaseCompleteHandler(object data)
		{
		}

		public void OnLoginStatusRetrieved(string message)
		{
		}
	}
}
