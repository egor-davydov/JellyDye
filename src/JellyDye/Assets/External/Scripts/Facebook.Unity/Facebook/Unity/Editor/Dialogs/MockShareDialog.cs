using System.Runtime.CompilerServices;

namespace Facebook.Unity.Editor.Dialogs
{
	internal class MockShareDialog : EditorFacebookMockDialog
	{
		public string SubTitle
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override string DialogTitle => null;

		protected override void DoGui()
		{
		}

		protected override void SendSuccessResult()
		{
		}

		protected override void SendCancelResult()
		{
		}

		private string GenerateFakePostID()
		{
			return null;
		}
	}
}
