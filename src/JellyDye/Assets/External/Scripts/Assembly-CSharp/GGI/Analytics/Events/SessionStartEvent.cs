namespace GGI.Analytics.Events
{
	public class SessionStartEvent : EventBase
	{
		public override string EventType => null;

		public SessionStartEvent(long sessionId, int sessionNumber)
		{
		}
	}
}
