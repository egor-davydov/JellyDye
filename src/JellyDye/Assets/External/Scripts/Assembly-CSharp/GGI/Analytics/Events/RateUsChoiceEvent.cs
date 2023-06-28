namespace GGI.Analytics.Events
{
	public class RateUsChoiceEvent : EventBase
	{
		public override string EventType => null;

		public RateUsChoiceEvent(int showedSession, int showedLevel, bool choice, int configShowSession, int configShowLevel, int showType)
		{
		}
	}
}
