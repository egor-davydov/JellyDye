namespace Sirenix.Utilities
{
	public interface ICacheNotificationReceiver
	{
		void OnFreed();

		void OnClaimed();
	}
}
