using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Core
{
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct, IPlugOptions
	{
		public T2 startValue;

		public T2 endValue;

		public T2 changeValue;

		public TPlugOptions plugOptions;

		public DOGetter<T1> getter;

		public DOSetter<T1> setter;

		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;

		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

		internal TweenerCore()
		{
		}

		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f)
		{
			return null;
		}

		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue)
		{
			return null;
		}

		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			return null;
		}

		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f)
		{
			return null;
		}

		public TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration = -1f)
		{
			return null;
		}

		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue)
		{
			return null;
		}

		public TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			return null;
		}

		public TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration = -1f)
		{
			return null;
		}

		internal override Tweener SetFrom(bool relative)
		{
			return null;
		}

		internal Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative)
		{
			return null;
		}

		internal sealed override void Reset()
		{
		}

		internal override bool Validate()
		{
			return false;
		}

		internal override float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		internal override bool Startup()
		{
			return false;
		}

		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			return false;
		}
	}
}
