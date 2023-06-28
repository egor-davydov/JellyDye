using System;
using UnityEngine;
using UnityEngine.Events;

namespace Obi
{
	public class ObiParticlePicker : MonoBehaviour
	{
		public class ParticlePickEventArgs : EventArgs
		{
			public int particleIndex;

			public Vector3 worldPosition;

			public ParticlePickEventArgs(int particleIndex, Vector3 worldPosition)
			{
			}
		}

		[Serializable]
		public class ParticlePickUnityEvent : UnityEvent<ParticlePickEventArgs>
		{
			public ParticlePickUnityEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		public ObiSolver solver;

		public float radiusScale;

		public ParticlePickUnityEvent OnParticlePicked;

		public ParticlePickUnityEvent OnParticleHeld;

		public ParticlePickUnityEvent OnParticleDragged;

		public ParticlePickUnityEvent OnParticleReleased;

		private Vector3 lastMousePos;

		private int pickedParticleIndex;

		private float pickedParticleDepth;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
