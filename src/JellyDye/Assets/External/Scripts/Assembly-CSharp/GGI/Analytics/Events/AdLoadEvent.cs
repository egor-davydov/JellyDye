using GGI.Ads;

namespace GGI.Analytics.Events
{
	public class AdLoadEvent : EventBase
	{
		public override string EventType => null;

		public AdLoadEvent(AdUnitType type, double time, MaxSdkBase.AdInfo fill)
		{
		}
	}
}
