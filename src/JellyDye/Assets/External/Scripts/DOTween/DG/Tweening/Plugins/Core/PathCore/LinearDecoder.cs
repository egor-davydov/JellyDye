using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class LinearDecoder : ABSPathDecoder
	{
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
		}

		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
		{
			return default(Vector3);
		}

		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
		}

		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
		}
	}
}
