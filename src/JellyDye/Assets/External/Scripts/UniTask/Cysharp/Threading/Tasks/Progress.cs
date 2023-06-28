using System;
using System.Collections.Generic;

namespace Cysharp.Threading.Tasks
{
	public static class Progress
	{
		private sealed class NullProgress<T> : IProgress<T>
		{
			public static readonly IProgress<T> Instance;

			private NullProgress()
			{
			}

			public void Report(T value)
			{
			}
		}

		private sealed class AnonymousProgress<T> : IProgress<T>
		{
			private readonly Action<T> action;

			public AnonymousProgress(Action<T> action)
			{
			}

			public void Report(T value)
			{
			}
		}

		private sealed class OnlyValueChangedProgress<T> : IProgress<T>
		{
			private readonly Action<T> action;

			private readonly IEqualityComparer<T> comparer;

			private bool isFirstCall;

			private T latestValue;

			public OnlyValueChangedProgress(Action<T> action, IEqualityComparer<T> comparer)
			{
			}

			public void Report(T value)
			{
			}
		}

		public static IProgress<T> Create<T>(Action<T> handler)
		{
			return null;
		}

		public static IProgress<T> CreateOnlyValueChanged<T>(Action<T> handler, IEqualityComparer<T> comparer = null)
		{
			return null;
		}
	}
}
