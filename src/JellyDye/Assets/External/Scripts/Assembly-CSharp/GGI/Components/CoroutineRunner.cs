using System.Collections;
using UnityEngine;

namespace GGI.Components
{
	public class CoroutineRunner : AutoSingletonMono<CoroutineRunner>
	{
		protected override void Awake()
		{
		}

		public Coroutine Begin(IEnumerator coroutine)
		{
			return null;
		}

		public void End(Coroutine coroutine)
		{
		}

		public CoroutineRunner()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
