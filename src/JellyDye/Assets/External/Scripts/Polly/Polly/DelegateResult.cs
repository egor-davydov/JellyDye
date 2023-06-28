using System;
using System.Runtime.CompilerServices;

namespace Polly
{
	public class DelegateResult<TResult>
	{
		public TResult Result
		{
			[CompilerGenerated]
			get
			{
				return default(TResult);
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public DelegateResult(TResult result)
		{
		}

		public DelegateResult(Exception exception)
		{
		}
	}
}
