using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class HapticReceiver : MonoBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		private float _outputLevel;

		[SerializeField]
		private bool _hapticsEnabled;

		public float outputLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hapticsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void Start()
		{
		}

		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
