using Lofelt.NiceVibrations;

public class HapticManager : MonoSingleton<HapticManager>
{
	public void Haptic(HapticPatterns.PresetType hapticType, bool skipAndroid = false)
	{
	}

	public void ContinuousHaptic(float modelHapticIntensityMax, float modelHapticSharpnessMax, int time)
	{
	}

	public void UpdateContinuousHaptic(float intensity, float sharpness)
	{
	}

	public void StopContinuousHaptic()
	{
	}

	public HapticManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
