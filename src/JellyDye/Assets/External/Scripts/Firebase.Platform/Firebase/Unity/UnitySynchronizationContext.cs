using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Scripting;

namespace Firebase.Unity
{
	[Preserve]
	internal class UnitySynchronizationContext : SynchronizationContext
	{
		private class SynchronizationContextBehavoir : MonoBehaviour
		{
			private Queue<Tuple<SendOrPostCallback, object>> callbackQueue;

			public Queue<Tuple<SendOrPostCallback, object>> CallbackQueue => null;

			[Preserve]
			private IEnumerator Start()
			{
				return null;
			}
		}

		private static UnitySynchronizationContext _instance;

		private Queue<Tuple<SendOrPostCallback, object>> queue;

		private SynchronizationContextBehavoir behavior;

		private int mainThreadId;

		private static Dictionary<int, ManualResetEvent> signalDictionary;

		private UnitySynchronizationContext(GameObject gameObject)
		{
		}

		public static void Create(GameObject gameObject)
		{
		}

		public static void Destroy()
		{
		}

		private ManualResetEvent GetThreadEvent()
		{
			return null;
		}

		public override void Post(SendOrPostCallback d, object state)
		{
		}

		public override void Send(SendOrPostCallback d, object state)
		{
		}
	}
}
