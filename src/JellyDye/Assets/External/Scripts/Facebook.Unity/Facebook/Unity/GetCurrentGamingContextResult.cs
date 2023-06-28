using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class GetCurrentGamingContextResult : ResultBase, IGetCurrentGamingContextResult, IResult
	{
		public string ContextId
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

		internal GetCurrentGamingContextResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
