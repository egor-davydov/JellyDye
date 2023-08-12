using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class GameInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public override void InstallBindings()
    {
      Container.BindInterfacesTo<GameInstaller>().FromInstance(this).AsSingle();

      BindServices();
      BindStates();
      BindFactories();
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
    
    public void Initialize()
    {
      //Debug.Log($"Initialize GameInstaller");
      GameStateMachine gameStateMachine = Container.Resolve<GameStateMachine>();
      gameStateMachine.Setup();
      gameStateMachine.Enter<LoadProgressState>();
    }

    private void BindServices()
    {
      Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
      Container.Bind<SceneLoader>().AsSingle();
      Container.Bind<ProgressService>().AsSingle();
      Container.Bind<PaintCountCalculationService>().AsSingle();
      Container.BindInterfacesAndSelfTo<ScreenshotService>().AsSingle();
      Container.BindInterfacesAndSelfTo<CameraService>().AsSingle();
      Container.BindInterfacesAndSelfTo<StaticDataService>().AsSingle();
      Container.BindInterfacesAndSelfTo<FinishLevelService>().AsSingle();
    }

    private void BindStates()
    {
      Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
      Container.Bind<LoadProgressState>().AsSingle();
      Container.Bind<LoadLevelState>().AsSingle();
      Container.Bind<GameLoopState>().AsSingle();
    }
  }
}