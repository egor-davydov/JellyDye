using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Progress;
using Code.StaticData;
using Code.StaticData.Level;
using Code.StaticData.Skins;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.Infrastructure.States
{
  public class WarmUpState : IState
  {
    private readonly StaticDataService _staticDataService;
    private readonly GameStateMachine _gameStateMachine;
    private readonly IAssetProvider _assetProvider;
    private readonly ProgressService _progressService;
      
    private string CurrentLevelId => _progressService.Progress.LevelData.CurrentLevelId;
    
    public WarmUpState(GameStateMachine gameStateMachine, IAssetProvider assetProvider,
      StaticDataService staticDataService, ProgressService progressService)
    {
      _gameStateMachine = gameStateMachine;
      _assetProvider = assetProvider;
      _staticDataService = staticDataService;
      _progressService = progressService;
    }
    
    public void Enter()
    {
      WarmUpCurrentAssets();
      WarmUpOtherAssets();
      _gameStateMachine.Enter<LoadLevelState, string>(CurrentLevelId);
    }

    public void Exit()
    {
    }

    private void WarmUpCurrentAssets()
    {
      SkinType equippedSkin = _progressService.Progress.SkinData.EquippedSkin;
      WarmUpSyringeSkin(_staticDataService.ForSkins().GetSkinByType(equippedSkin));
      WarmUpLevel(_staticDataService.ForLevels().GetConfigByLevelId(CurrentLevelId));
    }

    private void WarmUpOtherAssets()
    {
      _assetProvider.Load<GameObject>(AssetKey.LevelButton);
      foreach (LevelConfig levelConfig in _staticDataService.ForLevels().LevelConfigs) 
        WarmUpLevel(levelConfig);
      
      foreach (SkinConfig skinConfig in _staticDataService.ForSkins().SkinConfigs) 
        WarmUpSyringeSkin(skinConfig.SkinReference);
    }

    private void WarmUpLevel(LevelConfig levelConfig)
    {
      _assetProvider.Load<GameObject>(levelConfig.JelliesPrefabReference);
      foreach (JellyMeshConfig levelConfigJellyMeshConfig in levelConfig.JellyMeshConfigs)
        _assetProvider.Load<Mesh>(levelConfigJellyMeshConfig.MeshReference);
    }

    private void WarmUpSyringeSkin(AssetReference skinReference) => 
      _assetProvider.Load<GameObject>(skinReference);
  }
}