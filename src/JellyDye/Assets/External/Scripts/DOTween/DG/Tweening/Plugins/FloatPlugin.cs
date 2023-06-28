using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions>
	{
		public override void Reset(TweenerCore<float, float, FloatOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately, bool isRelative)
		{
		}

		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value)
		{
			return 0f;
		}

		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		public FloatPlugin()
		{
			((ABSTweenPlugin<, , >)(object)this)._002Ector();
		}
	}
}
