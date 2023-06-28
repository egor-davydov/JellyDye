namespace Facebook.Unity.Editor
{
	internal interface IEditorWrapper
	{
		void Init();

		void ShowLoginMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId, string permissions);

		void ShowAppRequestMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId);

		void ShowPayMockDialog(Utilities.Callback<ResultContainer> callback, string callbackId);

		void ShowMockShareDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId);

		void ShowMockFriendFinderDialog(Utilities.Callback<ResultContainer> callback, string subTitle, string callbackId);
	}
}
