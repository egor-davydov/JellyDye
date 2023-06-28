using Google.Play.Common.Internal;

namespace Google.Play.Review.Internal
{
	internal class ReviewAsyncOperation<TResult> : PlayAsyncOperationImpl<TResult, ReviewErrorCode>
	{
		public override bool IsSuccessful => false;

		public ReviewAsyncOperation()
		{
			((PlayAsyncOperationImpl<TResult, TError>)(object)this)._002Ector();
		}
	}
}
