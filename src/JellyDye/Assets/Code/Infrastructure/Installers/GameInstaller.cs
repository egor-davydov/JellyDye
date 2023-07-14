using Code.Gameplay.Logic;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
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
    }

    private void BindLoadingCurtain()
    {
      GameObject loadingCurtainObject = Container.InstantiatePrefab(Resources.Load<GameObject>("LoadingCurtain/LoadingCurtain"));
      Container
        .Bind<LoadingCurtain>()
        .FromInstance(loadingCurtainObject.GetComponent<LoadingCurtain>())
        .AsSingle();
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