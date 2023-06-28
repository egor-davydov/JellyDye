using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class BallPusher : MonoBehaviour
	{
		public float Force;

		public BallDemoBall TargetBall;

		protected Vector2 _direction;

		protected virtual void OnTriggerEnter2D(Collider2D collider)
		{
		}
	}
}
