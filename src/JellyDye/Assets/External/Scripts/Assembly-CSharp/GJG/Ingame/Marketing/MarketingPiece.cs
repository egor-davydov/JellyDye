using UnityEngine;

namespace GJG.Ingame.Marketing
{
	[DisallowMultipleComponent]
	public class MarketingPiece : MonoBehaviour
	{
		public FluidSimulation FluidSimulation;

		public Transform RootBone;

		public float Progress;

		public float ProgressSpeed;

		public Vector3 FinalScale;

		public Vector3 FinalPosition;

		public void OnDye(float dyeAmount)
		{
		}
	}
}
