using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	public struct PathOptions : IPlugOptions
	{
		public PathMode mode;

		public OrientType orientType;

		public AxisConstraint lockPositionAxis;

		public AxisConstraint lockRotationAxis;

		public bool isClosedPath;

		public Vector3 lookAtPosition;

		public Transform lookAtTransform;

		public float lookAhead;

		public bool hasCustomForwardDirection;

		public Quaternion forward;

		public bool useLocalPosition;

		public Transform parent;

		public bool isRigidbody;

		public bool stableZRotation;

		internal Quaternion startupRot;

		internal float startupZRot;

		internal bool addedExtraStartWp;

		internal bool addedExtraEndWp;

		public void Reset()
		{
		}
	}
}
