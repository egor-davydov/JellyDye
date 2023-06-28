using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class OfType<TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _OfType : AsyncEnumeratorBase<object, TResult>
		{
			public _OfType(IUniTaskAsyncEnumerable<object> source, CancellationToken cancellationToken)
			{
				((AsyncEnumeratorBase<, >)(object)this)._002Ector((IUniTaskAsyncEnumerable<TSource>)null, default(CancellationToken));
			}

			protected override bool TryMoveNextCore(bool sourceHasCurrent, out bool result)
			{
				result = default(bool);
				return false;
			}
		}

		private readonly IUniTaskAsyncEnumerable<object> source;

		public OfType(IUniTaskAsyncEnumerable<object> source)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
