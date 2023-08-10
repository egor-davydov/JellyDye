using Code.Gameplay.Logic;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Progress;
using UnityEngine;
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
      BindLoadingCurtain();
    }

    private void BindFactories()
    {
      Container.Bind<GameStateFactory>().AsSingle();
      Container.Bind<HudFactory>().AsSingle();
      Container.Bind<ColorChangerFactory>().AsSingle();
      Container.Bind<SyringeFactory>().AsSingle();
      Container.Bind<UIFactory>().AsSingle();
      Container.Bind<LevelButtonFactory>().AsSingle();
      Container.Bind<JelliesFactory>().AsSingle();
      Container.Bind<FinishButtonFactory>().AsSingle();
    }

    private void BindLoadingCurtain()
    {
      LoadingCurtain loadingCurtain = Container.InstantiatePrefabForComponent<LoadingCurtain>(Resources.Load<GameObject>("LoadingCurtain/LoadingCurtain"));
      Container
        .Bind<LoadingCurtain>()
        .FromInstance(loadingCurtain)
        .AsSingle();
      loadingCurtain.Hide();
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
      Container.Bind<CameraService>().AsSingle();
      Container.BindInterfacesAndSelfTo<StaticDataService>().AsSingle();
      Container.BindInterfacesAndSelfTo<LevelFinishService>().AsSingle();
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