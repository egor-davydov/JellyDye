using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class HapticClip : ScriptableObject
	{
		[SerializeField]
		public byte[] json;

		[SerializeField]
		public GamepadRumble gamepadRumble;
	}
}
