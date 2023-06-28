using System.Collections.Generic;

namespace GGI.Analytics.Events
{
	public class LevelEvent : EventBase
	{
		public override string EventType => null;

		public LevelEvent(int progress, int level, LevelStatus status, float duration, Dictionary<string, object> extraParams = null)
		{
		}

		public LevelEvent(int progress, string level, LevelStatus status, float duration, Dictionary<string, object> extraParams = null)
		{
		}
	}
}
