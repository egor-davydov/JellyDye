using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public class DOTweenPath : ABSAnimationComponent
	{
		public float delay;

		public float duration;

		public Ease easeType;

		public AnimationCurve easeCurve;

		public int loops;

		public string id;

		public LoopType loopType;

		public OrientType orientType;

		public Transform lookAtTransform;

		public Vector3 lookAtPosition;

		public float lookAhead;

		public bool autoPlay;

		public bool autoKill;

		public bool relative;

		public bool isLocal;

		public bool isClosedPath;

		public int pathResolution;

		public PathMode pathMode;

		public AxisConstraint lockRotation;

		public bool assignForwardAndUp;

		public Vector3 forwardDirection;

		public Vector3 upDirection;

		public bool tweenRigidbody;

		public List<Vector3> wps;

		public List<Vector3> fullWps;

		public Path path;

		public DOTweenInspectorMode inspectorMode;

		public PathType pathType;

		public HandlesType handlesType;

		public bool livePreview;

		public HandlesDrawMode handlesDrawMode;

		public float perspectiveHandleSize;

		public bool showIndexes;

		public bool showWpLength;

		public Color pathColor;

		public Vector3 lastSrcPosition;

		public Quaternion lastSrcRotation;

		public bool wpsDropdown;

		public float dropToFloorOffset;

		private static MethodInfo _miCreateTween;

		public static event Action<DOTweenPath> OnReset
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private static void Dispatch_OnReset(DOTweenPath path)
		{
		}

		private void Awake()
		{
		}

		private void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		public override void DOPlay()
		{
		}

		public void DOPlayById(string id)
		{
		}

		public void DOPlayAllById(string id)
		{
		}

		public override void DOPlayBackwards()
		{
		}

		public override void DOPlayForward()
		{
		}

		public override void DOPause()
		{
		}

		public override void DOTogglePause()
		{
		}

		public override void DORewind()
		{
		}

		public override void DORestart()
		{
		}

		public override void DORestart(bool fromHere)
		{
		}

		public override void DOComplete()
		{
		}

		public override void DOKill()
		{
		}

		public Tween GetTween()
		{
			return null;
		}

		public Vector3[] GetDrawPoints()
		{
			return null;
		}

		internal Vector3[] GetFullWps()
		{
			return null;
		}

		private void ReEvaluateRelativeTween()
		{
		}
	}
}
