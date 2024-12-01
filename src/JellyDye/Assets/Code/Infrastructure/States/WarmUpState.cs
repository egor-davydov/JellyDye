using System.Collections.Generic;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Infrastructure.States.Interfaces;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Progress;
using Code.StaticData;
using Code.StaticData.Level;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class WarmUpState : IState
  {
    private readonly StaticDataService _staticData;
    private readonly GameStateMachine _gameStateMachine;
    private readonly IAssetProvider _assetProvider;
    private readonly ProgressService _progress;

    private string CurrentLevelId => _progress.ForLevels.CurrentLevelId;

    public WarmUpState(GameStateMachine gameStateMachine, IAssetProvider assetProvider, StaticDataService staticData,
      ProgressService progress)
    {
      _gameStateMachine = gameStateMachine;
      _assetProvider = assetProvider;
      _staticData = staticData;
      _progress = progress;
    }

    public UniTaskVoid Enter()
    {
      WarmUpCurrentAssets();
      WarmUpOtherAssets();
      _gameStateMachine.Enter<LoadLevelState, string>(CurrentLevelId);
      return default;
    }

    public UniTaskVoid Exit()
    {
      return default;
    }

    private void WarmUpCurrentAssets()
    {
      SkinType equippedSkin = _progress.ForSkins.EquippedSkin;
      WarmUpSyringeSkin(_staticData.ForSkin(equippedSkin)).Forget();
      WarmUpLevel(_staticData.ForLevel(CurrentLevelId)).Forget();
    }

    private void WarmUpOtherAssets()
    {
      _assetProvider.Load<GameObject>(AssetKey.LevelButton);
      WarmUpLevelsQueued().Forget();
      WarmUpSyringesQueued().Forget();
    }

    private async UniTaskVoid WarmUpLevelsQueued()
    {
      foreach (LevelConfig levelConfig in _staticData.ForLevels.LevelConfigs)
        await WarmUpLevel(levelConfig);
    }

    private async UniTaskVoid WarmUpSyringesQueued()
    {
      foreach (SkinConfig skinConfig in _staticData.ForSkins.SkinConfigs)
        await WarmUpSyringeSkin(skinConfig);
    }

    private async UniTask WarmUpLevel(LevelConfig levelConfig)
    {
      //float startTime = Time.time;
      List<UniTask> tasks = new() { _assetProvider.Load<GameObject>(levelConfig.JelliesPrefabReference) };
      foreach (JellyMeshConfig levelConfigJellyMeshConfig in levelConfig.JellyMeshConfigs)
        tasks.Add(_assetProvider.Load<Mesh>(levelConfigJellyMeshConfig.MeshReference));
      await tasks;
      //Debug.Log($"Level {levelConfig.Id} loaded in {Time.time - startTime} seconds");
    }

    private async UniTask WarmUpSyringeSkin(SkinConfig skinConfig)
    {
      //float startTime = Time.time;
      var uniTask = _assetProvider.Load<GameObject>(skinConfig.SkinReference);
      await uniTask;
      //Debug.Log($"Skin {skinConfig.SkinType} loaded in {Time.time - startTime} seconds");
    }
  }
}