using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
	public sealed class Sequence : Tween
	{
		internal readonly List<Tween> sequencedTweens;

		private readonly List<ABSSequentiable> _sequencedObjs;

		internal float lastTweenInsertTime;

		internal Sequence()
		{
		}

		internal static Sequence DoPrepend(Sequence inSequence, Tween t)
		{
			return null;
		}

		internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
		{
			return null;
		}

		internal static Sequence DoAppendInterval(Sequence inSequence, float interval)
		{
			return null;
		}

		internal static Sequence DoPrependInterval(Sequence inSequence, float interval)
		{
			return null;
		}

		internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
		{
			return null;
		}

		internal override float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		internal override void Reset()
		{
		}

		internal override bool Validate()
		{
			return false;
		}

		internal override bool Startup()
		{
			return false;
		}

		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			return false;
		}

		internal static void Setup(Sequence s)
		{
		}

		internal static bool DoStartup(Sequence s)
		{
			return false;
		}

		internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			return false;
		}

		private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
		{
			return false;
		}

		private static void StableSortSequencedObjs(List<ABSSequentiable> list)
		{
		}

		private static bool IsAnyCallbackSet(Sequence s)
		{
			return false;
		}
	}
}
