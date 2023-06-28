using Google.Play.Common;
using Google.Play.Review.Internal;

namespace Google.Play.Review
{
	public class ReviewManager
	{
		private readonly ReviewPlayCoreTaskManager _reviewPlayCoreTaskManager;

		public PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> RequestReviewFlow()
		{
			return null;
		}

		public PlayAsyncOperation<VoidResult, ReviewErrorCode> LaunchReviewFlow(PlayReviewInfo reviewInfo)
		{
			return null;
		}

		private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> RequestReviewFlowInternal()
		{
			return null;
		}

		private PlayAsyncOperation<VoidResult, ReviewErrorCode> LaunchReviewFlowInternal(PlayReviewInfo reviewInfo)
		{
			return null;
		}
	}
}
