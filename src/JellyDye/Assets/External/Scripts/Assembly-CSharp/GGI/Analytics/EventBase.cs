using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GGI.Analytics
{
	public class EventBase
	{
		public Dictionary<string, string> EventData;

		public Dictionary<string, string> UserProperties;

		public string Id
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public long Time
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual string EventType => null;

		public string UserId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public long FirstEventTimestamp
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DeviceData Device
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public AppInfo App
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Platform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected EventBase()
		{
		}

		public void SetUserProperties()
		{
		}

		public void AppendData(EventParameter data)
		{
		}
	}
}
