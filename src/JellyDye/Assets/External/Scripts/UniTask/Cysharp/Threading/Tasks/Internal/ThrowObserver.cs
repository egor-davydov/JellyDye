using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal class ThrowObserver<T> : IObserver<T>
	{
		public static readonly ThrowObserver<T> Instance;

		private ThrowObserver()
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(T value)
		{
		}
	}
}
