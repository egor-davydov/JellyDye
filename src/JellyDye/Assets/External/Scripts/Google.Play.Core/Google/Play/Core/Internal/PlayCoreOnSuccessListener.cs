using System;
using System.Runtime.CompilerServices;

namespace Google.Play.Core.Internal
{
	public class PlayCoreOnSuccessListener<TAndroidJava> : PlayCoreJavaProxy
	{
		public event Action<TAndroidJava> OnTaskSucceeded
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

		public PlayCoreOnSuccessListener()
			: base(null)
		{
		}

		public void onSuccess(TAndroidJava result)
		{
		}
	}
}
