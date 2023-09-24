using System.Runtime.InteropServices;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class GameInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    [DllImport("__Internal")] private static extern bool IsYandexGames();
    
    public override void InstallBindings()
    {
      Container.BindInterfacesTo<GameInstaller>().FromInstance(this).AsSingle();

      BindServices();
      BindProgressServices();
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
      Container.Bind<PaintCountCalculationService>().AsSingle();
      Container.Bind<ParentsProvider>().AsSingle();
      Container.BindInterfacesAndSelfTo<AudioService>().AsSingle();
      Container.BindInterfacesAndSelfTo<ScreenshotService>().AsSingle();
      Container.BindInterfacesAndSelfTo<CameraService>().AsSingle();
      Container.BindInterfacesAndSelfTo<StaticDataService>().AsSingle();
      Container.BindInterfacesAndSelfTo<FinishLevelService>().AsSingle();
    }

    private void BindProgressServices()
    {
      Container.Bind<ProgressService>().AsSingle();
#if UNITY_EDITOR
      Container.Bind<ISaveLoadService>().To<FileSaveLoadService>().AsSingle();
#else
      if(IsYandexGames())
        Container.Bind<ISaveLoadService>().To<YandexSaveLoadService>().AsSingle();
      else
        Container.Bind<ISaveLoadService>().To<FileSaveLoadService>().AsSingle();
#endif
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