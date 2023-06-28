using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.CustomPlugins
{
	public class PureQuaternionPlugin : ABSTweenPlugin<Quaternion, Quaternion, NoOptions>
	{
		private static PureQuaternionPlugin _plug;

		public static PureQuaternionPlugin Plug()
		{
			return null;
		}

		public override void Reset(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion fromValue, bool setImmediately, bool isRelative)
		{
		}

		public override Quaternion ConvertToStartValue(TweenerCore<Quaternion, Quaternion, NoOptions> t, Quaternion value)
		{
			return default(Quaternion);
		}

		public override void SetRelativeEndValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Quaternion, Quaternion, NoOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, Quaternion changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Quaternion startValue, Quaternion changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		public PureQuaternionPlugin()
		{
			((ABSTweenPlugin<, , >)(object)this)._002Ector();
		}
	}
}
