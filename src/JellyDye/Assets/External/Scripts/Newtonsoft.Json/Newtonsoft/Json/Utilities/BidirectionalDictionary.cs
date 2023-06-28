using System.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		private readonly string _duplicateFirstErrorMessage;

		private readonly string _duplicateSecondErrorMessage;

		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		public void Set(TFirst first, TSecond second)
		{
		}

		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			second = default(TSecond);
			return false;
		}

		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			first = default(TFirst);
			return false;
		}
	}
}
