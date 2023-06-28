using System;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal
{
	internal sealed class PooledDelegate<T> : ITaskPoolNode<PooledDelegate<T>>
	{
		private static TaskPool<PooledDelegate<T>> pool;

		private PooledDelegate<T> nextNode;

		private readonly Action<T> runDelegate;

		private Action continuation;

		public unsafe ref PooledDelegate<T> NextNode => ref *(PooledDelegate<T>*)null;

		static PooledDelegate()
		{
		}

		private PooledDelegate()
		{
		}

		[MethodImpl(256)]
		public static Action<T> Create(Action continuation)
		{
			return null;
		}

		[MethodImpl(256)]
		private void Run(T _)
		{
		}
	}
}
