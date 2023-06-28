using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ToArray
	{
		internal static UniTask<TSource[]> ToArrayAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return default(UniTask<TSource[]>);
		}
	}
}
