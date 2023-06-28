using System;
using System.Collections.Generic;

namespace Polly
{
	public class ExceptionPredicates
	{
		private List<ExceptionPredicate> _predicates;

		public static readonly ExceptionPredicates None;

		internal void Add(ExceptionPredicate predicate)
		{
		}

		public Exception FirstMatchOrDefault(Exception ex)
		{
			return null;
		}
	}
}
