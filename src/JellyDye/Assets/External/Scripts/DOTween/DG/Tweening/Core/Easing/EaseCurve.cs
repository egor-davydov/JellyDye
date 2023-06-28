using UnityEngine;

namespace DG.Tweening.Core.Easing
{
	public class EaseCurve
	{
		private readonly AnimationCurve _animCurve;

		public EaseCurve(AnimationCurve animCurve)
		{
		}

		public float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod)
		{
			return 0f;
		}
	}
}
