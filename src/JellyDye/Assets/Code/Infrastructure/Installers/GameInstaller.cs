using Code.Gameplay.Logic;
using Code.Infrastructure.States;
using Code.Services;
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
      BindGameStateMachine();
      BindLoadingCurtain();
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
      Container.Bind<SceneLoader>().AsSingle();
    }

    private void BindStates()
    {
      Container.Bind<LoadProgressState>().AsSingle();
      Container.Bind<LoadLevelState>().AsSingle();
      Container.Bind<GameLoopState>().AsSingle();
    }

    private void BindGameStateMachine()
    {
      Container.Bind<GameStateFactory>().AsSingle();
      Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
    }
  }
}