using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class AbortDialogResult : ResultBase, IDialogResult, IResult
	{
		private bool Success
		{
			[CompilerGenerated]
			set
			{
			}
		}

		internal AbortDialogResult(ResultContainer resultContainer)
			: base(null)
		{
		}
	}
}
