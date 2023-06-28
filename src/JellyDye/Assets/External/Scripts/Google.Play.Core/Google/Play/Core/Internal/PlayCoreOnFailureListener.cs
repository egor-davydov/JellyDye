using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Google.Play.Core.Internal
{
	public class PlayCoreOnFailureListener : PlayCoreJavaProxy
	{
		public event Action<string, int> OnTaskFailed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public PlayCoreOnFailureListener()
			: base(null)
		{
		}

		public void onFailure(AndroidJavaObject exception)
		{
		}
	}
}
