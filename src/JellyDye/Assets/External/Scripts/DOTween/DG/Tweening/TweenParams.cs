using UnityEngine;

namespace DG.Tweening
{
	public class TweenParams
	{
		public static readonly TweenParams Params;

		internal object id;

		internal object target;

		internal UpdateType updateType;

		internal bool isIndependentUpdate;

		internal TweenCallback onStart;

		internal TweenCallback onPlay;

		internal TweenCallback onRewind;

		internal TweenCallback onUpdate;

		internal TweenCallback onStepComplete;

		internal TweenCallback onComplete;

		internal TweenCallback onKill;

		internal TweenCallback<int> onWaypointChange;

		internal bool isRecyclable;

		internal bool isSpeedBased;

		internal bool autoKill;

		internal int loops;

		internal LoopType loopType;

		internal float delay;

		internal bool isRelative;

		internal Ease easeType;

		internal EaseFunction customEase;

		internal float easeOvershootOrAmplitude;

		internal float easePeriod;

		public TweenParams Clear()
		{
			return null;
		}

		public TweenParams SetAutoKill(bool autoKillOnCompletion = true)
		{
			return null;
		}

		public TweenParams SetId(object id)
		{
			return null;
		}

		public TweenParams SetTarget(object target)
		{
			return null;
		}

		public TweenParams SetLoops(int loops, LoopType? loopType = null)
		{
			return null;
		}

		public TweenParams SetEase(Ease ease, float? overshootOrAmplitude = null, float? period = null)
		{
			return null;
		}

		public TweenParams SetEase(AnimationCurve animCurve)
		{
			return null;
		}

		public TweenParams SetEase(EaseFunction customEase)
		{
			return null;
		}

		public TweenParams SetRecyclable(bool recyclable = true)
		{
			return null;
		}

		public TweenParams SetUpdate(bool isIndependentUpdate)
		{
			return null;
		}

		public TweenParams SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
		{
			return null;
		}

		public TweenParams OnStart(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnPlay(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnRewind(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnUpdate(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnStepComplete(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnComplete(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnKill(TweenCallback action)
		{
			return null;
		}

		public TweenParams OnWaypointChange(TweenCallback<int> action)
		{
			return null;
		}

		public TweenParams SetDelay(float delay)
		{
			return null;
		}

		public TweenParams SetRelative(bool isRelative = true)
		{
			return null;
		}

		public TweenParams SetSpeedBased(bool isSpeedBased = true)
		{
			return null;
		}
	}
}
