using UnityEngine;

namespace Obi
{
	public class ObiCharacter : MonoBehaviour
	{
		[SerializeField]
		private float m_MovingTurnSpeed;

		[SerializeField]
		private float m_StationaryTurnSpeed;

		[SerializeField]
		private float m_JumpPower;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private float m_RunCycleLegOffset;

		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[SerializeField]
		private float m_GroundCheckDistance;

		private Rigidbody m_Rigidbody;

		private Animator m_Animator;

		private bool m_IsGrounded;

		private float m_OrigGroundCheckDistance;

		private const float k_Half = 0.5f;

		private float m_TurnAmount;

		private float m_ForwardAmount;

		private Vector3 m_GroundNormal;

		private float m_CapsuleHeight;

		private Vector3 m_CapsuleCenter;

		private CapsuleCollider m_Capsule;

		private bool m_Crouching;

		private void Start()
		{
		}

		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		private void PreventStandingInLowHeadroom()
		{
		}

		private void UpdateAnimator(Vector3 move)
		{
		}

		private void HandleAirborneMovement()
		{
		}

		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		private void ApplyExtraTurnRotation()
		{
		}

		public void OnAnimatorMove()
		{
		}

		private void CheckGroundStatus()
		{
		}
	}
}
