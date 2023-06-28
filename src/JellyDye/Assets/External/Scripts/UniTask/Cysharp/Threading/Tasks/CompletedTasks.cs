namespace Cysharp.Threading.Tasks
{
	internal static class CompletedTasks
	{
		public static readonly UniTask<AsyncUnit> AsyncUnit;

		public static readonly UniTask<bool> True;

		public static readonly UniTask<bool> False;

		public static readonly UniTask<int> Zero;

		public static readonly UniTask<int> MinusOne;

		public static readonly UniTask<int> One;
	}
}
