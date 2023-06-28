using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions>
	{
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately, bool isRelative)
		{
		}

		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value)
		{
			return default(Rect);
		}

		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		public RectPlugin()
		{
			((ABSTweenPlugin<, , >)(object)this)._002Ector();
		}
	}
}
