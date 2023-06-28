using System.Collections;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiLateFixedUpdater : ObiUpdater
	{
		public int substeps;

		private float accumulatedTime;

		private void OnValidate()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator RunLateFixedUpdate()
		{
			return null;
		}

		private void LateFixedUpdate()
		{
		}

		private void Update()
		{
		}
	}
}
