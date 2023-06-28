using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity
{
	internal class PayloadResult : ResultBase, IPayloadResult, IResult
	{
		public IDictionary<string, string> Payload
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

		public PayloadResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
