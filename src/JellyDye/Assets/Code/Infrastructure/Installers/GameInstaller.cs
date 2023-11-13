using System.Runtime.InteropServices;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using CrazyGames;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class GameInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    private PublishService _publishService;
    
    [DllImport("__Internal")]
    private static extern void WebDebugLog(string log);

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
      _publishService = Container.Resolve<PublishService>();
#if !UNITY_EDITOR && UNITY_WEBGL
      WebDebugLog($"IsOnCrazyGames={CrazySDK.IsOnCrazyGames}");
      WebDebugLog($"Application.absoluteURL={Application.absoluteURL}");
#endif
      BindPlatformDependServices();
      if (_publishService.IsOnYandexGames())
        _publishService.InitializeYandex(onPlayerInitialize: OnPlayerInitialized);
      else
        OnPlayerInitialized();
    }


    private void OnPlayerInitialized()
    {
      //Debug.Log($"Initialize GameInstaller");
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
      if (_publishService.IsOnYandexGames())
        Container.Bind<ISaveLoadService>().To<YandexSaveLoadService>().AsSingle();
      else
        BindFileSaveSystem();
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