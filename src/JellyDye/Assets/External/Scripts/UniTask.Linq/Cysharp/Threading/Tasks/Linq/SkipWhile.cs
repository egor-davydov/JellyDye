using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class SkipWhile<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private class _SkipWhile : AsyncEnumeratorBase<TSource, TSource>
		{
			private Func<TSource, bool> predicate;

			public _SkipWhile(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken)
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

		private readonly Func<TSource, bool> predicate;

		public SkipWhile(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
