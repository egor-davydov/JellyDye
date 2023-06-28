using System;
using Google.Play.Core.Internal;
using UnityEngine;

namespace Google.Play.Review.Internal
{
	internal class ReviewPlayCoreTaskManager : IDisposable
	{
		private readonly AndroidJavaObject _javaReviewManager;

		internal ReviewPlayCoreTaskManager()
		{
		}

		public PlayCoreTask<AndroidJavaObject> RequestReviewFlow()
		{
			return null;
		}

		public PlayCoreTask<AndroidJavaObject> LaunchReviewFlow(AndroidJavaObject reviewInfo)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
