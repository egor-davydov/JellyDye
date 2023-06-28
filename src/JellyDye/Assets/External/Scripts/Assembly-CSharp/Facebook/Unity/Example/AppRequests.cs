namespace Facebook.Unity.Example
{
	internal class AppRequests : MenuBase
	{
		private string requestMessage;

		private string requestTo;

		private string requestFilter;

		private string requestExcludes;

		private string requestMax;

		private string requestData;

		private string requestTitle;

		private string requestObjectID;

		private int selectedAction;

		private string[] actionTypeStrings;

		protected override void GetGui()
		{
		}

		private OGActionType? GetSelectedOGActionType()
		{
			return null;
		}
	}
}
