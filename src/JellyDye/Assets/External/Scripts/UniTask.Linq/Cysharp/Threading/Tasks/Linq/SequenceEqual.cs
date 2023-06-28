using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class SequenceEqual
	{
		internal static UniTask<bool> SequenceEqualAsync<TSource>(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}
	}
}
