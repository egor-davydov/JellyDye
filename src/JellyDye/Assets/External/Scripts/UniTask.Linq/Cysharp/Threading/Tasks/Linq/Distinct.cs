using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Distinct<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private class _Distinct : AsyncEnumeratorBase<TSource, TSource>
		{
			private readonly HashSet<TSource> set;

			public _Distinct(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken)
			{
				((AsyncEnumeratorBase<, >)(object)this)._002Ector((IUniTaskAsyncEnumerable<TSource>)null, default(CancellationToken));
			}

			protected override bool TryMoveNextCore(bool sourceHasCurrent, out bool result)
			{
				result = default(bool);
				return false;
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly IEqualityComparer<TSource> comparer;

		public Distinct(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal sealed class Distinct<TSource, TKey> : IUniTaskAsyncEnumerable<TSource>
	{
		private class _Distinct : AsyncEnumeratorBase<TSource, TSource>
		{
			private readonly HashSet<TKey> set;

			private readonly Func<TSource, TKey> keySelector;

			public _Distinct(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
			{
				((AsyncEnumeratorBase<, >)(object)this)._002Ector((IUniTaskAsyncEnumerable<TSource>)null, default(CancellationToken));
			}

			protected override bool TryMoveNextCore(bool sourceHasCurrent, out bool result)
			{
				result = default(bool);
				return false;
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly Func<TSource, TKey> keySelector;

		private readonly IEqualityComparer<TKey> comparer;

		public Distinct(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
