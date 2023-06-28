using System;
using System.Collections.Generic;
using UnityEngine;

namespace Google.Play.Core.Internal
{
	public class PlayCoreEventHandler : MonoBehaviour
	{
		private static PlayCoreEventHandler _instance;

		private readonly Queue<Action> _sharedEventQueue;

		private readonly Queue<Action> _localEventQueue;

		public static void CreateInScene()
		{
		}

		public static void HandleEvent(Action action)
		{
		}

		private void Awake()
		{
		}

		private void HandleEventInternal(Action action)
		{
		}

		private void Update()
		{
		}
	}
}
