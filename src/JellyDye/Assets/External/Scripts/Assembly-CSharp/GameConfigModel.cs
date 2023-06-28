using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameConfigModel
{
	public int[] LevelOrder;

	public int[] NewModelLevels;

	public int[] NewToolOrder;

	public List<List<int>> ColorSwatchRewardedList;

	public bool IsFluidDirectionConstant;

	public int RotateSyringeMode;

	public float SyringeVelocityDissipation;

	public float DropperVelocityDissipation;

	public bool DyeUpdateOld;

	public bool NoDripAnim;

	public int FirstLevelNoExtraColors;

	public int RefMode;

	public int GalleryMode;

	public int ActivePiecesMode;

	public int ColorPickMode;

	public int SyringeAnimMode;

	public int FillMode;

	public int PlayMode;

	public int NoBorderMode;

	public int SyringeAutoRefill;

	public int StickWithButton;

	public Vector2 DropperRadiusMinMax;

	public float DropperLerpTimer;

	public float MoveSpeed;

	public float HoldTimerToDye;

	public float DyeRotateSpeed;

	public float DyeForceStart;

	public float DyeForceEnd;

	public float FullDyeTime;

	public float SyringeStickMovement;

	public float AutoFillStartPercent;

	public float HapticIntensityMax;

	public float HapticIntensityMin;

	public float HapticSharpnessMax;

	public float HapticSharpnessMin;

	public float InterNextButtonTimer;

	public float InterStopDyeTimer;

	public float InterPickColorTimer;

	public float FirstLevelNoInterTimer;

	public float SessionNoInterTimer;

	public float InterLevelEndTimer;

	public float OnboardedSessionNoInterTimer;

	public float OnboardedInterNextButtonTimer;

	public float OnboardedInterStopDyeTimer;

	public float OnboardedInterPickColorTimer;

	public float OnboardedInterLevelEndTimer;

	public int OnboardedInterProgress;

	public int NextButtonLocation;

	public int AccuracyMode;

	public float ColorChangeSnapTime;

	public float ProgressAmountForNewSyringe;

	public float AccuracyRewardedMultiplier;

	public float NoThanksTime;

	public float DyeRadius;

	public int SyringeForceRewarded;

	public int NewColorsMode;

	public int FirstColorIsRight;

	public int AccuracyWithoutProgress;

	public int EpicFillMode;

	public int VIPOfferMode;

	public int VIPOfferButton;

	public int PerformanceBadFrameCount;

	public int PerformanceSimulationEnabled;

	public int AudioEnabled;

	public int MinimalAudioMode;
}
