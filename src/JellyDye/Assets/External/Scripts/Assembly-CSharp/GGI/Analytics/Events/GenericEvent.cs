using System.Runtime.CompilerServices;

namespace GGI.Analytics.Events
{
	public class GenericEvent : EventBase
	{
		public override string EventType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public GenericEvent(string eventName)
		{
		}
	}
}
