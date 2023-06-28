namespace AmazonAds
{
	public class AdRequest
	{
		internal IAdRequest client;

		public Amazon.OnFailureDelegate onFailed;

		public Amazon.OnFailureWithErrorDelegate onFailedWithError;

		public Amazon.OnSuccessDelegate onSuccess;

		public AdRequest()
		{
		}

		public AdRequest(IAdRequest adRequest)
		{
		}

		public void PutCustomTarget(string key, string value)
		{
		}

		public void SetRefreshFlag(bool flag)
		{
		}

		public void SetAutoRefresh()
		{
		}

		public void SetAutoRefresh(int secs)
		{
		}

		public void ResumeAutoRefresh()
		{
		}

		public void StopAutoRefresh()
		{
		}

		public void PauseAutoRefresh()
		{
		}

		public void LoadAd()
		{
		}
	}
}
