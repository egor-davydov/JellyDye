using System;
using System.Collections.Generic;

[Serializable]
public class PlayerDataModel
{
	public int CurrentLevel;

	public int ModelIndex;

	public int ModelRejectionCount;

	public int PerformanceMode;

	public List<int> CompletedGalleryLevels;

	public List<int> CompletedSkins;

	public bool VibrationDisabled;

	public bool AudioDisabled;

	public string CurrentVersion;

	public bool IsVip;

	public float AccuracyProgress;

	public bool IsSubscribed;
}
