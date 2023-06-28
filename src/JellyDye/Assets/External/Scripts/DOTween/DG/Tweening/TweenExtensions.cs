using UnityEngine;

namespace DG.Tweening
{
	public static class TweenExtensions
	{
		public static void Complete(this Tween t)
		{
		}

		public static void Complete(this Tween t, bool withCallbacks)
		{
		}

		public static void Flip(this Tween t)
		{
		}

		public static void ForceInit(this Tween t)
		{
		}

		public static void Goto(this Tween t, float to, bool andPlay = false)
		{
		}

		public static void Kill(this Tween t, bool complete = false)
		{
		}

		public static T Pause<T>(this T t) where T : Tween
		{
			return null;
		}

		public static T Play<T>(this T t) where T : Tween
		{
			return null;
		}

		public static void PlayBackwards(this Tween t)
		{
		}

		public static void PlayForward(this Tween t)
		{
		}

		public static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
		}

		public static void Rewind(this Tween t, bool includeDelay = true)
		{
		}

		public static void SmoothRewind(this Tween t)
		{
		}

		public static void TogglePause(this Tween t)
		{
		}

		public static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false)
		{
		}

		public static YieldInstruction WaitForCompletion(this Tween t)
		{
			return null;
		}

		public static YieldInstruction WaitForRewind(this Tween t)
		{
			return null;
		}

		public static YieldInstruction WaitForKill(this Tween t)
		{
			return null;
		}

		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		public static YieldInstruction WaitForPosition(this Tween t, float position)
		{
			return null;
		}

		public static Coroutine WaitForStart(this Tween t)
		{
			return null;
		}

		public static int CompletedLoops(this Tween t)
		{
			return 0;
		}

		public static float Delay(this Tween t)
		{
			return 0f;
		}

		public static float ElapsedDelay(this Tween t)
		{
			return 0f;
		}

		public static float Duration(this Tween t, bool includeLoops = true)
		{
			return 0f;
		}

		public static float Elapsed(this Tween t, bool includeLoops = true)
		{
			return 0f;
		}

		public static float ElapsedPercentage(this Tween t, bool includeLoops = true)
		{
			return 0f;
		}

		public static float ElapsedDirectionalPercentage(this Tween t)
		{
			return 0f;
		}

		public static bool IsActive(this Tween t)
		{
			return false;
		}

		public static bool IsBackwards(this Tween t)
		{
			return false;
		}

		public static bool IsComplete(this Tween t)
		{
			return false;
		}

		public static bool IsInitialized(this Tween t)
		{
			return false;
		}

		public static bool IsPlaying(this Tween t)
		{
			return false;
		}

		public static int Loops(this Tween t)
		{
			return 0;
		}

		public static Vector3 PathGetPoint(this Tween t, float pathPercentage)
		{
			return default(Vector3);
		}

		public static Vector3[] PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10)
		{
			return null;
		}

		public static float PathLength(this Tween t)
		{
			return 0f;
		}
	}
}
