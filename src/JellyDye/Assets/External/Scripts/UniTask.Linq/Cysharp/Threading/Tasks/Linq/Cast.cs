using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Cast<TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _Cast : AsyncEnumeratorBase<object, TResult>
		{
			public _Cast(IUniTaskAsyncEnumerable<object> source, CancellationToken cancellationToken)
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

		public Cast(IUniTaskAsyncEnumerable<object> source)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
