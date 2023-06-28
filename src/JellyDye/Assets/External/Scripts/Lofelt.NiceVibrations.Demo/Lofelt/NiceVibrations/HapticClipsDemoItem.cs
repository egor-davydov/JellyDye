using System;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	[Serializable]
	public class HapticClipsDemoItem
	{
		public string Name;

		public HapticClip HapticClip;

		public Sprite AssociatedSprite;

		public AudioSource AssociatedSound;
	}
}
