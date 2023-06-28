using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class RegularPresetsDemoManager : DemoManager
	{
		public Image IconImage;

		public Animator IconImageAnimator;

		public Sprite IdleSprite;

		public Sprite SelectionSprite;

		public Sprite SuccessSprite;

		public Sprite WarningSprite;

		public Sprite FailureSprite;

		public Sprite RigidSprite;

		public Sprite SoftSprite;

		public Sprite LightSprite;

		public Sprite MediumSprite;

		public Sprite HeavySprite;

		protected WaitForSeconds _turnDelay;

		protected WaitForSeconds _shakeDelay;

		protected int _idleAnimationParameter;

		protected virtual void Awake()
		{
		}

		protected virtual void ChangeImage(Sprite newSprite)
		{
		}

		protected virtual IEnumerator ChangeImageCoroutine(Sprite newSprite)
		{
			return null;
		}

		public virtual void SelectionButton()
		{
		}

		public virtual void SuccessButton()
		{
		}

		public virtual void WarningButton()
		{
		}

		public virtual void FailureButton()
		{
		}

		public virtual void RigidButton()
		{
		}

		public virtual void SoftButton()
		{
		}

		public virtual void LightButton()
		{
		}

		public virtual void MediumButton()
		{
		}

		public virtual void HeavyButton()
		{
		}
	}
}
