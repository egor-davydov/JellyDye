using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DeveGames.CoroutineSystem
{
	public class CoroutineManager : MonoSingleton<CoroutineManager>
	{
		public static Coroutine StartChildCoroutine(IEnumerator method)
		{
			return null;
		}

		public static void StartChildCoroutine(string method)
		{
		}

		public static void StopChildCoroutine(Coroutine method)
		{
		}

		public static void StopChildCoroutine(string method)
		{
		}

		public static void DoAfterFixedUpdate(Action actionToInvoke)
		{
		}

		public static Coroutine DoAfterGivenTime(float waitTime, Action actionToInvoke)
		{
			return null;
		}

		public static Coroutine DoAfterGivenUnscaledTime(float waitTime, Action actionToInvoke)
		{
			return null;
		}

		public IEnumerator ProcessMultipleCoroutines(IEnumerable<IEnumerator> coroutineArray, Action actionToInvoke = null)
		{
			return null;
		}

		private static IEnumerator Wait(float time, Action actionToInvoke)
		{
			return null;
		}

		private static IEnumerator WaitUnscaled(float time, Action actionToInvoke)
		{
			return null;
		}

		public CoroutineManager()
		{
			((MonoSingleton<>)(object)this)._002Ector();
		}
	}
}
