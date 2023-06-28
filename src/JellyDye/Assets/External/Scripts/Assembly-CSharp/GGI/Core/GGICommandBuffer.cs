using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GGI.Core
{
	public class GGICommandBuffer
	{
		private List<GGICommandBufferElement> _commands
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

		public void OnShowInterstitial()
		{
		}

		public void OnShowRewarded()
		{
		}

		public void OnLevelEvent()
		{
		}

		public GGICommandBufferElement.Element GetLastCommand()
		{
			return default(GGICommandBufferElement.Element);
		}
	}
}
