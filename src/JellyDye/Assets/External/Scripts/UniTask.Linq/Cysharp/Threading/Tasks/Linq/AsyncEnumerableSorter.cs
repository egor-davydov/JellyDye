namespace Cysharp.Threading.Tasks.Linq
{
	internal abstract class AsyncEnumerableSorter<TElement>
	{
		internal abstract UniTask ComputeKeysAsync(TElement[] elements, int count);

		internal abstract int CompareKeys(int index1, int index2);

		internal UniTask<int[]> SortAsync(TElement[] elements, int count)
		{
			return default(UniTask<int[]>);
		}

		private void QuickSort(int[] map, int left, int right)
		{
		}
	}
}
