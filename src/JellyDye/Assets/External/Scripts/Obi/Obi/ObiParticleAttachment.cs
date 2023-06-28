using System;
using UnityEngine;

namespace Obi
{
	public class ObiParticleAttachment : MonoBehaviour
	{
		public enum AttachmentType
		{
			Static = 0,
			Dynamic = 1
		}

		[SerializeField]
		[HideInInspector]
		private ObiActor m_Actor;

		[SerializeField]
		[HideInInspector]
		private Transform m_Target;

		[SerializeField]
		[HideInInspector]
		private ObiParticleGroup m_ParticleGroup;

		[SerializeField]
		[HideInInspector]
		private AttachmentType m_AttachmentType;

		[SerializeField]
		[HideInInspector]
		private bool m_ConstrainOrientation;

		[SerializeField]
		[HideInInspector]
		private float m_Compliance;

		[SerializeField]
		[HideInInspector]
		[Delayed]
		private float m_BreakThreshold;

		private ObiPinConstraintsBatch pinBatch;

		private int pinBatchIndex;

		[NonSerialized]
		private int[] m_SolverIndices;

		[NonSerialized]
		private Vector3[] m_PositionOffsets;

		[NonSerialized]
		private Quaternion[] m_OrientationOffsets;

		public ObiActor actor => null;

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObiParticleGroup particleGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isBound => false;

		public AttachmentType attachmentType
		{
			get
			{
				return default(AttachmentType);
			}
			set
			{
			}
		}

		public bool constrainOrientation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float compliance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float breakThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}

		private void Actor_OnBlueprintLoaded(ObiActor act, ObiActorBlueprint blueprint)
		{
		}

		private void Actor_OnBeginStep(ObiActor act, float stepTime)
		{
		}

		private void Actor_OnEndStep(ObiActor actor, float stepTime)
		{
		}

		private void Bind()
		{
		}

		private void Enable(AttachmentType type)
		{
		}

		private void Disable(AttachmentType type)
		{
		}

		private void UpdateStaticAttachment(float stepTime)
		{
		}

		private void UpdateDynamicAttachment(float stepTime)
		{
		}
	}
}
