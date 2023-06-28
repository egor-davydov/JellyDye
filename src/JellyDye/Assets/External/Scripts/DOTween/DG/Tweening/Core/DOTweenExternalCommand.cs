using System;
using System.Runtime.CompilerServices;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Core
{
	public static class DOTweenExternalCommand
	{
		public static event Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath
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

		internal static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}
	}
}
