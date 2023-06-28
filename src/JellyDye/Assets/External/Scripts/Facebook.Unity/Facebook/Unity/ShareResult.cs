using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class ShareResult : ResultBase, IShareResult, IResult
	{
		public string PostId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal static string PostIDKey => null;

		internal ShareResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
