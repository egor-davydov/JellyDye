using System;
using UnityEngine;

namespace Obi
{
	public abstract class ObiColliderBase : MonoBehaviour
	{
		[SerializeField]
		private ObiCollisionMaterial material;

		[SerializeField]
		private int phase;

		[SerializeField]
		private float thickness;

		protected ObiColliderHandle shapeHandle;

		protected IntPtr oniCollider;

		protected ObiRigidbodyBase obiRigidbody;

		protected bool wasUnityColliderEnabled;

		protected bool dirty;

		protected ObiShapeTracker tracker;

		public ObiCollisionMaterial CollisionMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Phase
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Thickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ObiShapeTracker Tracker => null;

		public ObiColliderHandle Handle => null;

		public IntPtr OniCollider => (IntPtr)0;

		public ObiRigidbodyBase Rigidbody => null;

		protected abstract void CreateTracker();

		protected abstract Component GetUnityCollider(ref bool enabled);

		protected abstract void FindSourceCollider();

		protected void CreateRigidbody()
		{
		}

		private void OnTransformParentChanged()
		{
		}

		protected void AddCollider()
		{
		}

		protected void RemoveCollider()
		{
		}

		public void UpdateIfNeeded()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
