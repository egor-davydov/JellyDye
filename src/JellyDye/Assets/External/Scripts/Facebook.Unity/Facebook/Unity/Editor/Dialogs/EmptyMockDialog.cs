using System.Runtime.CompilerServices;

namespace Facebook.Unity.Editor.Dialogs
{
	internal class EmptyMockDialog : EditorFacebookMockDialog
	{
		public string EmptyDialogTitle
		{
			[CompilerGenerated]
			get
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
	}
}
