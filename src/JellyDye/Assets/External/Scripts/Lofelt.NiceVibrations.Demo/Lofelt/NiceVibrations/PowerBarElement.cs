using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class PowerBarElement : MonoBehaviour
	{
		public float BumpDuration;

		public Color NormalColor;

		public Color InactiveColor;

		public AnimationCurve Curve;

		protected Image _image;

		protected float _bumpDuration;

		protected bool _active;

		protected bool _activeLastFrame;

		protected virtual void Awake()
		{
		}

		public virtual void SetActive(bool status)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual IEnumerator ColorBump()
		{
			return null;
		}
	}
}
