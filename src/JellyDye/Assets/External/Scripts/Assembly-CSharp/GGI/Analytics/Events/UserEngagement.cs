namespace GGI.Analytics.Events
{
	public class UserEngagement : EventBase
	{
		public override string EventType => null;

		public UserEngagement(double engagementTime, string origin = "switch")
		{
		}
	}
}
