namespace GGI.Analytics.Events
{
	public class InAppPurchaseEvent : EventBase
	{
		public override string EventType => null;

		public InAppPurchaseEvent(string productName, string currency, double price, int validated)
		{
		}
	}
}
