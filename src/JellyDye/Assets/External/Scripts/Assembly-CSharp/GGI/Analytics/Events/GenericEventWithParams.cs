using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GGI.Analytics.Events
{
	public class GenericEventWithParams : EventBase
	{
		public override string EventType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public GenericEventWithParams(string type, Dictionary<string, object> extraParams)
		{
		}
	}
}
