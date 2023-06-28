using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	public class SpiralPlugin : ABSTweenPlugin<Vector3, Vector3, SpiralOptions>
	{
		public static readonly Vector3 DefaultDirection;

		public override void Reset(TweenerCore<Vector3, Vector3, SpiralOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 fromValue, bool setImmediately, bool isRelative)
		{
		}

		public static ABSTweenPlugin<Vector3, Vector3, SpiralOptions> Get()
		{
			return null;
		}

		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, SpiralOptions> t, Vector3 value)
		{
			return default(Vector3);
		}

		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, SpiralOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Vector3, Vector3, SpiralOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(SpiralOptions options, float unitsXSecond, Vector3 changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(SpiralOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		public SpiralPlugin()
		{
			((ABSTweenPlugin<T1, T2, TPlugOptions>)(object)this)._002Ector();
		}
	}
}
