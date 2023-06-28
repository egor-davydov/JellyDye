using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions>
	{
		public const float MinLookAhead = 0.0001f;

		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately, bool isRelative)
		{
		}

		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get()
		{
			return null;
		}

		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value)
		{
			return null;
		}

		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice)
		{
		}

		public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice)
		{
		}

		public PathPlugin()
		{
			((ABSTweenPlugin<, , >)(object)this)._002Ector();
		}
	}
}
