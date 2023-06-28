namespace AmazonAds
{
	public abstract class IAdInterstitial
	{
		public abstract void FetchAd(AdResponse adResponse);

		public abstract void Show();
	}
}
