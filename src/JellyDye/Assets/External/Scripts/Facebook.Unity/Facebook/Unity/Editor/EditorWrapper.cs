namespace Facebook.Unity.Editor
{
	internal class EditorWrapper : IEditorWrapper
	{
		private IFacebookCallbackHandler callbackHandler;

		public EditorWrapper(IFacebookCallbackHandler callbackHandler)
		{
		}

		public void Init()
		{
		}

		public void ShowLoginMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string permsisions)
		{
		}

		public void ShowAppRequestMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId)
		{
		}

		public void ShowPayMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId)
		{
		}

		public void ShowMockShareDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId)
		{
		}

		public void ShowMockFriendFinderDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId)
		{
		}

		private void ShowEmptyMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string title)
		{
		}
	}
}
