using Code.Gameplay.Hud.PaintChange;
using Code.Gameplay.Logic;
using Code.Gameplay.Syringe;
using Code.Infrastructure.Installers;
using Code.Services;
using Code.Services.Factories;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<int>
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly LoadingCurtain _loadingCurtain;
    private readonly HudFactory _hudFactory;
    private readonly SyringeFactory _syringeFactory;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain,
      HudFactory hudFactory, SyringeFactory syringeFactory)
    {
      _gameStateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _loadingCurtain = loadingCurtain;
      _hudFactory = hudFactory;
      _syringeFactory = syringeFactory;
    }
    
    public void Enter(int index)
    {
      Debug.Log($"Enter LoadLevelState LoadingSceneIndex: '{index}'");
      _sceneLoader.StartLoad(index, OnLoadComplete);
    }

    public void Exit()
    {
    }

    private void OnLoadComplete()
    {
      GameObject syringeObject = InitSyringe();
      InitHud(syringeObject);
      _gameStateMachine.Enter<GameLoopState>();
    }

    private GameObject InitSyringe()
    {
      GameObject syringeObject = _syringeFactory.CreateSyringe();
      syringeObject.GetComponent<PaintInjection>().SyringeReset();
      return syringeObject;
    }

    private void InitHud(GameObject syringeObject)
    {
      SyringePaint syringePaint = syringeObject.GetComponent<SyringePaint>();
      GameObject hudObject = _hudFactory.CreateHud();
      hudObject.GetComponentInChildren<ColorChangersContainer>().Initialize(syringePaint, new []{Color.red, Color.green, Color.blue, });
    }
  }
}