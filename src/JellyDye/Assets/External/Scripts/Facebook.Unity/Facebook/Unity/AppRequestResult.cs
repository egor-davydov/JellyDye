using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class AppRequestResult : ResultBase, IAppRequestResult, IResult
	{
		public string RequestID
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

		public IEnumerable<string> To
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

		public AppRequestResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
