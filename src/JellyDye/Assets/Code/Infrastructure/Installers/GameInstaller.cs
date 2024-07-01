using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Code.Services.Providers;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class GameInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public override void InstallBindings()
    {
      Container.BindInterfacesTo<GameInstaller>().FromInstance(this).AsSingle();

      BindServices();
      BindProviders();
      BindStates();
      BindFactories();
    }

    public void Initialize()
    {
      BindPlatformDependServices();
      SetupStatesAndMoveToNextState();
    }

    private void BindFactories()
    {
      Container.Bind<GameStateFactory>().AsSingle();
      Container.Bind<HudFactory>().AsSingle();
      Container.Bind<JarFactory>().AsSingle();
      Container.Bind<SyringeFactory>().AsSingle();
      Container.Bind<WindowFactory>().AsSingle();
      Container.Bind<LevelButtonFactory>().AsSingle();
      Container.Bind<JelliesFactory>().AsSingle();
      Container.Bind<GreenButtonFactory>().AsSingle();
    }

    private void SetupStatesAndMoveToNextState()
    {
      GameStateMachine gameStateMachine = Container.Resolve<GameStateMachine>();
      gameStateMachine.SetupStates();
      gameStateMachine.Enter<InitializationState>();
    }

    private void BindServices()
    {
      Container.Bind<IAssetProvider>().To<AddressablesAssetProvider>().AsSingle();
      Container.Bind<SceneLoader>().AsSingle();
      Container.Bind<PublishService>().AsSingle();
      Container.Bind<PaintCountCalculationService>().AsSingle();
      Container.Bind<StaticDataService>().AsSingle();
      Container.Bind<ProgressService>().AsSingle();
      Container.BindInterfacesAndSelfTo<AnalyticsService>().AsSingle();
      Container.BindInterfacesAndSelfTo<AudioService>().AsSingle();
      Container.BindInterfacesAndSelfTo<ScreenshotService>().AsSingle();
      Container.BindInterfacesAndSelfTo<CameraService>().AsSingle();
      Container.BindInterfacesAndSelfTo<FinishLevelService>().AsSingle();
    }

    private void BindProviders()
    {
      Container.Bind<ParentsProvider>().AsSingle();
      Container.Bind<SyringeProvider>().AsSingle();
      Container.Bind<HudProvider>().AsSingle();
    }

    private void BindPlatformDependServices()
    {
      PublishService publishService = Container.Resolve<PublishService>();
      if (publishService.IsOnYandexGames())
        Container.Bind<ISaveLoadService>().To<YandexSaveLoadService>().AsSingle();
      else
        Container.Bind<ISaveLoadService>().To<FileSyncSaveLoadService>().AsSingle();
    }

    private void BindStates()
    {
      Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
      Container.Bind<InitializationState>().AsSingle();
      Container.Bind<LoadProgressState>().AsSingle();
      Container.Bind<LoadLevelState>().AsSingle();
      Container.Bind<GameLoopState>().AsSingle();
    }
  }
}