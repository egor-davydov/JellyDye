namespace Facebook.Unity.Example
{
	internal class DialogShare : MenuBase
	{
		private string shareLink;

		private string shareTitle;

		private string shareDescription;

		private string shareImage;

		private string feedTo;

		private string feedLink;

		private string feedTitle;

		private string feedCaption;

		private string feedDescription;

		private string feedImage;

		private string feedMediaSource;

		protected override bool ShowDialogModeSelector()
		{
			return false;
		}

		protected override void GetGui()
		{
		}
	}
}
