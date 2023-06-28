using System;

namespace DG.Tweening.Core.Easing
{
	public static class EaseManager
	{
		private const float _PiOver2 = (float)Math.PI / 2f;

		private const float _TwoPi = (float)Math.PI * 2f;

		public static float Evaluate(Tween t, float time, float duration, float overshootOrAmplitude, float period)
		{
			return 0f;
		}

		public static float Evaluate(Ease easeType, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
		{
			return 0f;
		}

		public static EaseFunction ToEaseFunction(Ease ease)
		{
			return null;
		}

		internal static bool IsFlashEase(Ease ease)
		{
			return false;
		}
	}
}
