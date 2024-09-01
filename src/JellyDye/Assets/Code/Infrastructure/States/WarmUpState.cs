using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Progress;
using Code.StaticData;
using Code.StaticData.Level;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
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
    
    public async void Enter()
    {
      await WarmUpCurrentAssets();
      WarmUpOtherAssets();
      _gameStateMachine.Enter<LoadLevelState, string>(CurrentLevelId);
    }

    public void Exit()
    {
    }

    private async UniTask WarmUpCurrentAssets()
    {
      SkinType equippedSkin = _progressService.Progress.SkinData.EquippedSkin;
      await WarmUpSyringeSkin(_staticDataService.ForSkins().GetSkinByType(equippedSkin));
      await WarmUpLevel(_staticDataService.ForLevels().GetConfigByLevelId(CurrentLevelId));
    }

    private void WarmUpOtherAssets()
    {
      _assetProvider.Load<GameObject>(AssetKey.LevelButton);
      WarmUpLevelsQueued();
      WarmUpSyringesQueued();
    }

    private async void WarmUpLevelsQueued()
    {
      foreach (LevelConfig levelConfig in _staticDataService.ForLevels().LevelConfigs)
        await WarmUpLevel(levelConfig);
    }

    private async void WarmUpSyringesQueued()
    {
      foreach (SkinConfig skinConfig in _staticDataService.ForSkins().SkinConfigs)
        await WarmUpSyringeSkin(skinConfig);
    }

    private async UniTask WarmUpLevel(LevelConfig levelConfig)
    {
      float startTime = Time.time;
      List<UniTask> tasks = new() { _assetProvider.Load<GameObject>(levelConfig.JelliesPrefabReference) };
      foreach (JellyMeshConfig levelConfigJellyMeshConfig in levelConfig.JellyMeshConfigs)
        tasks.Add(_assetProvider.Load<Mesh>(levelConfigJellyMeshConfig.MeshReference));
      await UniTask.WaitUntil(() => tasks.All(x => x.Status == UniTaskStatus.Succeeded));
      //Debug.Log($"Level {levelConfig.Id} loaded in {Time.time - startTime} seconds");
    }

    private async UniTask WarmUpSyringeSkin(SkinConfig skinConfig)
    {
      float startTime = Time.time;
      var uniTask = _assetProvider.Load<GameObject>(skinConfig.SkinReference);
      await UniTask.WaitUntil(() => uniTask.Status == UniTaskStatus.Succeeded);
      //Debug.Log($"Skin {skinConfig.SkinType} loaded in {Time.time - startTime} seconds");
    }
  }
}