using System.Collections;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class MMUIShaker : MonoBehaviour
	{
		public float Amplitude;

		public float Frequency;

		public bool Shaking;

		protected Vector3 _initialPosition;

		protected Vector3 _shakePosition;

		protected RectTransform _rectTransform;

		protected virtual void Start()
		{
		}

		public virtual IEnumerator Shake(float duration)
		{
			return null;
		}

		protected virtual void Update()
		{
		}
	}
}
