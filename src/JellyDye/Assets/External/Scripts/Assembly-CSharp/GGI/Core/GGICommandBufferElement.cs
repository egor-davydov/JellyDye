using System;
using System.Runtime.CompilerServices;

namespace GGI.Core
{
	public class GGICommandBufferElement
	{
		public enum Element
		{
			Unknown = 0,
			ShowInterstitial = 1,
			ShowRewarded = 2,
			LevelEvent = 3
		}

		public DateTime Time;

		public Element Command
		{
			[CompilerGenerated]
			get
			{
				return default(Element);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
