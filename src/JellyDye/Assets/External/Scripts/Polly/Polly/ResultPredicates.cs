using System.Collections.Generic;

namespace Polly
{
	public class ResultPredicates<TResult>
	{
		private List<ResultPredicate<TResult>> _predicates;

		public static readonly ResultPredicates<TResult> None;

		public bool AnyMatch(TResult result)
		{
			return false;
		}
	}
}
