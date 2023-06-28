using System;
using System.Collections;
using UnityEngine;

namespace Facebook.Unity
{
	internal class FacebookScheduler : MonoBehaviour
	{
		public void Schedule(Action action, long delay)
		{
		}

		public IEnumerator DelayEvent(Action action, long delay)
		{
			return null;
		}
	}
}
