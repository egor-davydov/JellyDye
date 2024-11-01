﻿using Code.Constants;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Gameplay.UI.NewSkin;
using Code.Services.Factories;
using Code.Services.Providers;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class NewSkinSceneService
  {
    private readonly CameraService _cameraService;
    private readonly SceneLoader _sceneLoader;
    private readonly ParentsProvider _parentsProvider;
    private readonly SyringeFactory _syringeFactory;
    private readonly InputService _inputService;
    private readonly StaticDataService _staticDataService;

    private Transform _newSkinStandTransform;
    private Vector3 _skinRotationPoint;
    private NewSkinHud _newSkinHud;
    private AudioSource _audioSource;

    private SceneInstance _sceneInstance;

    public NewSkinSceneService(SceneLoader sceneLoader, CameraService cameraService, ParentsProvider parentsProvider,
      SyringeFactory syringeFactory, InputService inputService, StaticDataService staticDataService)
    {
      _sceneLoader = sceneLoader;
      _parentsProvider = parentsProvider;
      _syringeFactory = syringeFactory;
      _inputService = inputService;
      _staticDataService = staticDataService;
      _cameraService = cameraService;
    }

    private NewSkinSceneConfig NewSkinSceneConfig => _staticDataService.ForSkins().NewSkinSceneConfig;

    public void Initialize(Transform newSkinStandTransform, Vector3 skinRotationPoint, NewSkinHud newSkinHud, AudioSource audioSource)
    {
      _audioSource = audioSource;
      _newSkinHud = newSkinHud;
      _skinRotationPoint = skinRotationPoint;
      _newSkinStandTransform = newSkinStandTransform;
    }

    public async UniTask ShowSkinScene(SkinType skinType)
    {
      await LoadSceneAndDisableMainSceneRenderers();

      _audioSource.PlayOneShot(NewSkinSceneConfig.NewSkinSound);
      UniTask hudInitTask = _newSkinHud.InitializeAsync(skinType);
      SyringeMesh syringeMesh = await _syringeFactory.CreateMesh(skinType, _newSkinStandTransform);
      syringeMesh.transform.localScale = Vector3.one;
      SyringeRotation syringeRotation = syringeMesh.gameObject.AddComponent<SyringeRotation>();
      syringeRotation.Construct(_inputService, _staticDataService);
      syringeRotation.Initialize(_skinRotationPoint);
      await hudInitTask;
      await _newSkinHud.CloseSkinButtonClick;
    }

    private async UniTask LoadSceneAndDisableMainSceneRenderers()
    {
      UniTask<SceneInstance> loadSceneTask = _sceneLoader.Load(SceneName.NewSkin, LoadSceneMode.Additive);
      MainSceneRenderersSetActive(false);
      _sceneInstance = await loadSceneTask;
    }

    public async UniTask HideSkinScene()
    {
      await Addressables.UnloadSceneAsync(_sceneInstance);
      MainSceneRenderersSetActive(true);
    }

    private void MainSceneRenderersSetActive(bool active)
    {
      _cameraService.LevelCamera.gameObject.SetActive(active);
      _parentsProvider.ParentForOther.gameObject.SetActive(active);
      _parentsProvider.ParentForUI.gameObject.SetActive(active);
      _parentsProvider.ParentForGameplay.gameObject.SetActive(active);
    }
  }
}