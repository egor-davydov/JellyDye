using Code.Gameplay.Hud.PaintChange;
using Code.Gameplay.Logic;
using Code.Gameplay.Syringe;
using Code.Infrastructure.Installers;
using Code.Services;
using Code.Services.Factories;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
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
    
    public void Enter(string sceneName)
    {
      _loadingCurtain.Show();
      Debug.Log($"Enter LoadLevelState LoadingSceneName: '{sceneName}'");
      _sceneLoader.StartLoad(sceneName, OnLoadComplete);
    }

    public void Exit() => 
      _loadingCurtain.Hide();

    private void OnLoadComplete()
    {
      GameObject syringeObject = _syringeFactory.CreateSyringe();
      InitHud(syringeObject);
      _gameStateMachine.Enter<GameLoopState>();
    }

    private void InitHud(GameObject syringeObject)
    {
      SyringePaint syringePaint = syringeObject.GetComponent<SyringePaint>();
      GameObject hudObject = _hudFactory.CreateHud();
      hudObject.GetComponentInChildren<ColorChangersContainer>().Initialize(syringePaint, new []{Color.red, Color.green, Color.blue, });
    }
  }
}