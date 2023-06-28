using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;

public class LevelManager : MonoSingleton<LevelManager>
{
	public static Action OnNewModelLevelReached;

	public LevelPrefabController Level;

	public ColorPalette ColorPalette;

	public SyringeActor ActiveDyer;

	public SyringeActor Syringe;

	public DropperActor Dropper;

	public int SelectedLevelIndex;

	public float _levelTimer;

	private float lastPieceFallMoment;

	public int _levelId;

	private bool _isNewOfferMissed;

	public bool _isEpicFillUnlocked;

	private List<SyringeEpicFillActor> EpicFillActors;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AutoFill()
	{
	}

	public void LoadLevel(int levelId = -1)
	{
	}

	[Button]
	public void LevelEnd()
	{
	}

	public void CheckSyringeAndGoNext()
	{
	}

	public void OnPieceFall()
	{
	}

	private void SendPieceEvent()
	{
	}

	public void ActivateWinScreen()
	{
	}

	private bool IsNewModelLevelReached()
	{
		return false;
	}

	public void ChangeTool()
	{
	}

	[Button]
	public void OnEpicFillUnlocked()
	{
	}

	public void DestroyLevel()
	{
	}

	public void OnStickButton()
	{
	}

	public void OnStickButtonUp()
	{
	}

	public LevelManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
