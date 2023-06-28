using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Plugins
{
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions>
	{
		public override void Reset(TweenerCore<double, double, NoOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately, bool isRelative)
		{
		}

		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value)
		{
			return 0.0;
		}

		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		public DoublePlugin()
		{
			((ABSTweenPlugin<, , >)(object)this)._002Ector();
		}
	}
}
