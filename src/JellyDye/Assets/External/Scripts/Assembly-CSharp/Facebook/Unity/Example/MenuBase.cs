namespace Facebook.Unity.Example
{
	internal abstract class MenuBase : ConsoleBase
	{
		private static ShareDialogMode shareDialogMode;

		protected abstract void GetGui();

		protected virtual bool ShowDialogModeSelector()
		{
			return false;
		}

		protected virtual bool ShowBackButton()
		{
			return false;
		}

		protected void HandleResult(IResult result)
		{
		}

		protected void HandleLimitedLoginResult(IResult result)
		{
		}

		protected void OnGUI()
		{
		}

		private void AddStatus()
		{
		}

		private void AddBackButton()
		{
		}

		private void AddLogButton()
		{
		}

		private void AddDialogModeButtons()
		{
		}

		private void AddDialogModeButton(ShareDialogMode mode)
		{
		}
	}
}
