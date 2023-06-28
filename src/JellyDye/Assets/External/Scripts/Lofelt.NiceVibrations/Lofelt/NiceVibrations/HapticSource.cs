using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class HapticSource : MonoBehaviour
	{
		private const int DEFAULT_PRIORITY = 128;

		public HapticClip clip;

		public int priority;

		private float seekTime;

		[SerializeField]
		private HapticPatterns.PresetType _fallbackPreset;

		[SerializeField]
		private bool _loop;

		[SerializeField]
		private float _level;

		[SerializeField]
		private float _frequencyShift;

		private static HapticSource loadedHapticSource;

		private static HapticSource lastPlayedHapticSource;

		public HapticPatterns.PresetType fallbackPreset
		{
			get
			{
				return default(HapticPatterns.PresetType);
			}
			set
			{
			}
		}

		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float level
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float frequencyShift
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		static HapticSource()
		{
		}

		public void Play()
		{
		}

		private bool CanPlay()
		{
			return false;
		}

		private bool IsLoaded()
		{
			return false;
		}

		public void Stop()
		{
		}

		public void Seek(float time)
		{
		}

		public void OnDisable()
		{
		}
	}
}
