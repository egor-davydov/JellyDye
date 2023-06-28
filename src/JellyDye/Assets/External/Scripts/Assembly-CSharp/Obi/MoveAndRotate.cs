using System;
using UnityEngine;

namespace Obi
{
	public class MoveAndRotate : MonoBehaviour
	{
		[Serializable]
		public class Vector3andSpace
		{
			public Vector3 value;

			public Space space;
		}

		public Vector3andSpace moveUnitsPerSecond;

		public Vector3andSpace rotateDegreesPerSecond;

		public bool ignoreTimescale;

		private float m_LastRealTime;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
