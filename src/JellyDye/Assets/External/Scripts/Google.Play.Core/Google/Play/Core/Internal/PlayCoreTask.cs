using System;
using UnityEngine;

namespace Google.Play.Core.Internal
{
	public class PlayCoreTask<TAndroidJava> : IDisposable
	{
		private readonly AndroidJavaObject _javaTask;

		public PlayCoreTask(AndroidJavaObject javaTask)
		{
		}

		public void RegisterOnSuccessCallback(Action<TAndroidJava> onSuccess)
		{
		}

		public void RegisterOnFailureCallback(Action<string, int> onFailure)
		{
		}

		private void AddOnSuccessListener(AndroidJavaProxy listenerProxy)
		{
		}

		private void AddOnFailureListener(AndroidJavaProxy listenerProxy)
		{
		}

		public void Dispose()
		{
		}
	}
}
