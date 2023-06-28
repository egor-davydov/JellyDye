using System;
using System.Collections;

namespace Obi
{
	public class CoroutineJob
	{
		public class ProgressInfo
		{
			public string userReadableInfo;

			public float progress;

			public ProgressInfo(string userReadableInfo, float progress)
			{
			}
		}

		private object result;

		private bool isDone;

		private bool raisedException;

		private bool stop;

		private Exception e;

		public int asyncThreshold;

		public object Result => null;

		public bool IsDone => false;

		public bool RaisedException => false;

		private void Init()
		{
		}

		public static object RunSynchronously(IEnumerator coroutine)
		{
			return null;
		}

		public IEnumerator Start(IEnumerator coroutine)
		{
			return null;
		}

		public void Stop()
		{
		}
	}
}
