using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks.Internal;
using UnityEngine;
using UnityEngine.LowLevel;

namespace Cysharp.Threading.Tasks
{
	public static class PlayerLoopHelper
	{
		private static readonly ContinuationQueue ThrowMarkerContinuationQueue;

		private static readonly PlayerLoopRunner ThrowMarkerPlayerLoopRunner;

		private static int mainThreadId;

		private static string applicationDataPath;

		private static SynchronizationContext unitySynchronizationContetext;

		private static ContinuationQueue[] yielders;

		private static PlayerLoopRunner[] runners;

		public static SynchronizationContext UnitySynchronizationContext => null;

		public static int MainThreadId => 0;

		internal static string ApplicationDataPath => null;

		public static bool IsMainThread => false;

		internal static bool IsEditorApplicationQuitting
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, bool injectOnFirst, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner)
		{
			return null;
		}

		private static PlayerLoopSystem[] RemoveRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, Type loopRunnerType)
		{
			return null;
		}

		private static PlayerLoopSystem[] InsertUniTaskSynchronizationContext(PlayerLoopSystem loopSystem)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		private static int FindLoopSystemIndex(PlayerLoopSystem[] playerLoopList, Type systemType)
		{
			return 0;
		}

		private static void InsertLoop(PlayerLoopSystem[] copyList, InjectPlayerLoopTimings injectTimings, Type loopType, InjectPlayerLoopTimings targetTimings, int index, bool injectOnFirst, Type loopRunnerYieldType, Type loopRunnerType, PlayerLoopTiming playerLoopTiming)
		{
		}

		public static void Initialize(ref PlayerLoopSystem playerLoop, InjectPlayerLoopTimings injectTimings = InjectPlayerLoopTimings.All)
		{
		}

		public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action)
		{
		}

		private static void ThrowInvalidLoopTiming(PlayerLoopTiming playerLoopTiming)
		{
		}

		public static void AddContinuation(PlayerLoopTiming timing, Action continuation)
		{
		}

		public static void DumpCurrentPlayerLoop()
		{
		}

		public static bool IsInjectedUniTaskPlayerLoop()
		{
			return false;
		}
	}
}
