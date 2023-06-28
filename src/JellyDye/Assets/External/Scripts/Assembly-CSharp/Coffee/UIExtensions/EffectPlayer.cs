using System;
using System.Collections.Generic;
using UnityEngine;

namespace Coffee.UIExtensions
{
	[Serializable]
	public class EffectPlayer
	{
		public bool play;

		public float initialPlayDelay;

		public float duration;

		public bool loop;

		public float loopDelay;

		public AnimatorUpdateMode updateMode;

		private static List<Action> s_UpdateActions;

		private float _time;

		private Action<float> _callback;

		public void OnEnable(Action<float> callback = null)
		{
		}

		public void OnDisable()
		{
		}

		public void Play(Action<float> callback = null)
		{
		}

		public void Stop()
		{
		}

		private void OnWillRenderCanvases()
		{
		}
	}
}
