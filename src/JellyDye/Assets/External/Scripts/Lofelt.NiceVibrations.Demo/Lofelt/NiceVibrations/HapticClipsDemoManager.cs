using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class HapticClipsDemoManager : DemoManager
	{
		public Image IconImage;

		public Animator IconImageAnimator;

		public List<HapticClipsDemoItem> DemoItems;

		protected WaitForSeconds _iconChangeDelay;

		protected int _idleAnimationParameter;

		protected virtual void Awake()
		{
		}

		public virtual void PlayHapticClip(int index)
		{
		}

		protected virtual IEnumerator ChangeIcon(Sprite newSprite)
		{
			return null;
		}

		protected virtual IEnumerator BackToIdle()
		{
			return null;
		}

		private void OnHapticsStopped()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}
	}
}
