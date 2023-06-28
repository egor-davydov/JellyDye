using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class MMSpriteReplace : MonoBehaviour
	{
		public Sprite OnSprite;

		public Sprite OffSprite;

		public bool StartsOn;

		protected Image _image;

		protected SpriteRenderer _spriteRenderer;

		protected MMTouchButton _mmTouchButton;

		public bool CurrentValue => false;

		protected virtual void Start()
		{
		}

		protected virtual void Initialization()
		{
		}

		public virtual void Swap()
		{
		}

		public virtual void SwitchToOffSprite()
		{
		}

		protected virtual void SpriteOff()
		{
		}

		public virtual void SwitchToOnSprite()
		{
		}

		protected virtual void SpriteOn()
		{
		}
	}
}
