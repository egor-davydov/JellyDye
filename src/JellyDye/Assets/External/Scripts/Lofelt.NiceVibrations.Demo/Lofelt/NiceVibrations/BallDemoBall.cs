using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class BallDemoBall : MonoBehaviour
	{
		public bool HapticsEnabled;

		public ParticleSystem HitParticles;

		public ParticleSystem HitPusherParticles;

		public LayerMask WallMask;

		public LayerMask PusherMask;

		public MMUIShaker LogoShaker;

		public AudioSource EmphasisAudioSource;

		protected Rigidbody2D _rigidBody;

		protected float _lastRaycastTimestamp;

		protected Animator _ballAnimator;

		protected int _hitAnimationParameter;

		protected virtual void Awake()
		{
		}

		protected virtual void OnCollisionEnter2D(Collision2D collision)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void HitBottom()
		{
		}

		protected virtual void HitWall()
		{
		}

		public virtual void HitPusher()
		{
		}
	}
}
