using System.Collections.Generic;

namespace Facebook.Unity
{
	internal class CallbackManager
	{
		private IDictionary<string, object> facebookDelegates;

		private int nextAsyncId;

		public string AddFacebookDelegate<T>(FacebookDelegate<T> callback) where T : IResult
		{
			return null;
		}

		public void OnFacebookResponse(IInternalResult result)
		{
		}

		private static void CallCallback(object callback, IResult result)
		{
		}

		private static bool TryCallCallback<T>(object callback, IResult result) where T : IResult
		{
			return false;
		}
	}
}
