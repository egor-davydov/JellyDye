namespace GGI.Analytics.Events
{
	public class LowPerformanceEvent : EventBase
	{
		public override string EventType => null;

		public LowPerformanceEvent(int level, float fps, int threshold)
		{
		}

		public LowPerformanceEvent(string level, float fps, int threshold)
		{
		}
	}
}
