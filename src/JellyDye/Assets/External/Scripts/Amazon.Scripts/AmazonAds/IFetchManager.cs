namespace AmazonAds
{
	public interface IFetchManager
	{
		void dispense();

		void start();

		void stop();

		bool isEmpty();

		AdResponse peek();
	}
}
