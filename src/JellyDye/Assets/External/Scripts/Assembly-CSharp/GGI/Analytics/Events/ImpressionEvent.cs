using System.Runtime.CompilerServices;
using GGI.Ads;

namespace GGI.Analytics.Events
{
	public class ImpressionEvent : EventBase
	{
		public override string EventType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ImpressionEvent(AdUnitType type, string network, string placement, double revenue, string creativeId, bool appendEngagement = false)
		{
		}
	}
}
