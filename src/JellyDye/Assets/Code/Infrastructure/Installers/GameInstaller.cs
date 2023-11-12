#if !UNITY_EDITOR && UNITY_WEBGL
using CrazyGames;
using UnityEngine;
#endif
using System;
using System.Runtime.InteropServices;
using AOT;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class GameInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    private const string LoadSceneName = "Load";
    private static Action _onSdkInitialize;
    private static Action _onPlayerInitialize;
    private static Action _onInitializeError;

    [DllImport("__Internal")]
    private static extern bool IsYandexGames();
    [DllImport("__Internal")]
    private static extern void WebDebugLog(string log);
    [DllImport("__Internal")]
    private static extern void TryInitializeYandexGames(Action onSdkInitialize, Action onPlayerInitialize, Action onInitializeError);

    public override void InstallBindings()
    {
      Container.BindInterfacesTo<GameInstaller>().FromInstance(this).AsSingle();
      
      BindServices();
      BindProgressServices();
      BindStates();
      BindFactories();
    }

    public void Initialize()
    {
      Container.Resolve<StaticDataService>().LoadData();
#if !UNITY_EDITOR && UNITY_WEBGL
      bool isOnCrazyGames = CrazySDK.IsOnCrazyGames;
      WebDebugLog($"IsOnCrazyGames={isOnCrazyGames}");
      WebDebugLog($"Application.absoluteURL={Application.absoluteURL}");
      Uri uri = new Uri(Application.absoluteURL);

      if (uri.Host == CrazySDK.Instance.GetSettings().whitelistedDomains[0]) 
        InitializeYandex(onSdkInitialize: OnSdkInitialized, onPlayerInitialize: OnPlayerInitialized, onInitializeError: OnPlayerInitialized);
      else
        OnPlayerInitialized();
#else
      OnPlayerInitialized();
#endif
    }
    
    private void InitializeYandex(Action onSdkInitialize, Action onPlayerInitialize, Action onInitializeError)
    {
      _onSdkInitialize = onSdkInitialize;
      _onPlayerInitialize = onPlayerInitialize;
      _onInitializeError = onInitializeError;
      TryInitializeYandexGames(SdkInitialized, PlayerInitialized, InitializeError);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void SdkInitialized() =>
      _onSdkInitialize.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void PlayerInitialized() =>
      _onPlayerInitialize.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void InitializeError() =>
      _onInitializeError.Invoke();

    private void OnSdkInitialized()
    {
      SceneManager.LoadScene(LoadSceneName);
      Container.Resolve<PublishService>().InvokeSdkInitEvent();
    }

    private void OnPlayerInitialized()
    {
      //Debug.Log($"Initialize GameInstaller");
      BindPlatformDependServices();
      MoveToNextState();
    }

    private void BindFactories()
    {
      Container.Bind<GameStateFactory>().AsSingle();
      Container.Bind<HudFactory>().AsSingle();
      Container.Bind<ColorChangerFactory>().AsSingle();
      Container.Bind<SyringeFactory>().AsSingle();
      Container.Bind<WindowFactory>().AsSingle();
      Container.Bind<LevelButtonFactory>().AsSingle();
      Container.Bind<JelliesFactory>().AsSingle();
      Container.Bind<GreenButtonFactory>().AsSingle();
    }

    private void MoveToNextState()
    {
      GameStateMachine gameStateMachine = Container.Resolve<GameStateMachine>();
      gameStateMachine.Setup();
      gameStateMachine.Enter<LoadProgressState>();
    }

    private void BindServices()
    {
      Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
      Container.Bind<SceneLoader>().AsSingle();
      Container.Bind<PublishService>().AsSingle();
      Container.Bind<PaintCountCalculationService>().AsSingle();
      Container.Bind<ParentsProvider>().AsSingle();
      Container.Bind<StaticDataService>().AsSingle();
      Container.BindInterfacesAndSelfTo<AnalyticsService>().AsSingle();
      Container.BindInterfacesAndSelfTo<AudioService>().AsSingle();
      Container.BindInterfacesAndSelfTo<ScreenshotService>().AsSingle();
      Container.BindInterfacesAndSelfTo<CameraService>().AsSingle();
      Container.BindInterfacesAndSelfTo<FinishLevelService>().AsSingle();
    }

    private void BindProgressServices()
    {
      Container.Bind<ProgressService>().AsSingle();
    }

    private void BindPlatformDependServices()
    {
#if UNITY_EDITOR
      BindFileSaveSystem();
#else
      if (IsYandexGames())
        Container.Bind<ISaveLoadService>().To<YandexSaveLoadService>().AsSingle();
      else
        BindFileSaveSystem();
#endif
    }

    private void BindFileSaveSystem() =>
      Container.Bind<ISaveLoadService>().To<FileSaveLoadService>().AsSingle();

    private void BindStates()
    {
      Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
      Container.Bind<LoadProgressState>().AsSingle();
      Container.Bind<LoadLevelState>().AsSingle();
      Container.Bind<GameLoopState>().AsSingle();
    }
  }
}