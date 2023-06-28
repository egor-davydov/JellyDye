using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class StatePool<T1>
	{
		private static readonly ConcurrentQueue<StateTuple<T1>> queue;

		[MethodImpl(256)]
		public static StateTuple<T1> Create(T1 item1)
		{
			return null;
		}

		[MethodImpl(256)]
		public static void Return(StateTuple<T1> tuple)
		{
		}
	}
	internal static class StatePool<T1, T2>
	{
		private static readonly ConcurrentQueue<StateTuple<T1, T2>> queue;

		[MethodImpl(256)]
		public static StateTuple<T1, T2> Create(T1 item1, T2 item2)
		{
			return null;
		}

		[MethodImpl(256)]
		public static void Return(StateTuple<T1, T2> tuple)
		{
		}
	}
	internal static class StatePool<T1, T2, T3>
	{
		private static readonly ConcurrentQueue<StateTuple<T1, T2, T3>> queue;

		[MethodImpl(256)]
		public static StateTuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3)
		{
			return null;
		}

		[MethodImpl(256)]
		public static void Return(StateTuple<T1, T2, T3> tuple)
		{
		}
	}
}
