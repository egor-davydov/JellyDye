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
    private static Action _onInitialize;

    [DllImport("__Internal")]
    private static extern bool IsYandexGames();

    [DllImport("__Internal")]
    private static extern void TryInitializeYandexGames(Action onInitialize);

    public override void InstallBindings()
    {
      Container.BindInterfacesTo<GameInstaller>().FromInstance(this).AsSingle();


#if !UNITY_EDITOR && UNITY_WEBGL
      InitializeYandex(onInitialize: OnYandexInitialized);
#else
      BindPlatformDependServices();
#endif

      BindServices();
      BindProgressServices();
      BindStates();
      BindFactories();
    }

    public void Initialize()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
#else
      MoveToNextState();
#endif 
    }

    private void InitializeYandex(Action onInitialize)
    {
      _onInitialize = onInitialize;
      TryInitializeYandexGames(Initialized);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void Initialized() =>
      _onInitialize.Invoke();

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

    private void OnYandexInitialized()
    {
      //Debug.Log($"Initialize GameInstaller");
      BindPlatformDependServices();
      MoveToNextState();
    }

    private void MoveToNextState()
    {
      SceneManager.LoadScene(1);
      GameStateMachine gameStateMachine = Container.Resolve<GameStateMachine>();
      gameStateMachine.Setup();
      gameStateMachine.Enter<LoadProgressState>();
    }

    private void BindServices()
    {
      Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
      Container.Bind<SceneLoader>().AsSingle();
      Container.Bind<YandexService>().AsSingle();
      Container.Bind<PaintCountCalculationService>().AsSingle();
      Container.Bind<ParentsProvider>().AsSingle();
      Container.BindInterfacesAndSelfTo<AnalyticsService>().AsSingle();
      Container.BindInterfacesAndSelfTo<AudioService>().AsSingle();
      Container.BindInterfacesAndSelfTo<ScreenshotService>().AsSingle();
      Container.BindInterfacesAndSelfTo<CameraService>().AsSingle();
      Container.BindInterfacesAndSelfTo<StaticDataService>().AsSingle();
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