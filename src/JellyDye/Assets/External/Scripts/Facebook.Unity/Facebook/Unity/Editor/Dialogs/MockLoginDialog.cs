namespace Facebook.Unity.Editor.Dialogs
{
	internal class MockLoginDialog : EditorFacebookMockDialog
	{
		private string accessToken;

		protected override string DialogTitle => null;

		protected override void DoGui()
		{
		}

		protected override void SendSuccessResult()
		{
		}
	}
}
