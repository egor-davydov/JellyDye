using GGI.Ads;
using GGI.Data.Responses.Stepback;

namespace GGI.Analytics.Events
{
	public class StepbackFill : EventBase
	{
		public override string EventType => null;

		public StepbackFill(AdUnitType type, StepbackFillEvent fill, bool success)
		{
		}
	}
}
