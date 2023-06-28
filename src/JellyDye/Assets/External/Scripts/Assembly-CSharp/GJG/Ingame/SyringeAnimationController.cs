using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

namespace GJG.Ingame
{
	public class SyringeAnimationController : MonoBehaviour
	{
		[SerializeField]
		private GameObject piston;

		[SerializeField]
		private GameObject fluid;

		[SerializeField]
		private float TotalFluidAmount;

		private Tweener pushTween;

		private Tweener fluidTween;

		public UnityAction ColorFillCompleted;

		private float remainingFluidAmount => 0f;

		public void PushPiston()
		{
		}

		public void StopPiston()
		{
		}

		public void ChangeColor(Material colorMaterial)
		{
		}

		public void FillWithRawColor()
		{
		}

		public float ReturnRemainingFluitAmound()
		{
			return 0f;
		}

		public void Empty()
		{
		}

		public void FillColor(Material mat)
		{
		}

		public bool CheckColorAndFillRate(Material colorMaterial)
		{
			return false;
		}
	}
}
