namespace GGI.Analytics.Events
{
	public class MarketEvent : EventBase
	{
		public override string EventType => null;

		public MarketEvent(string type, int id, double cost)
		{
		}

		public MarketEvent(string type, string id, double cost)
		{
		}
	}
}
