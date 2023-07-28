using Code.Infrastructure.States;
using Code.Services.Progress;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Hud
{
  public class ReloadLevel : MonoBehaviour
  {
    [SerializeField] private Button _reloadLevelButton;
    private GameStateMachine _gameStateMachine;
    private ProgressService _progressService;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, ProgressService progressService)
    {
      _progressService = progressService;
      _gameStateMachine = gameStateMachine;
    }

    private void Awake() => 
      _reloadLevelButton.onClick.AddListener(ReloadLevelClick);

    private void ReloadLevelClick() => 
      _gameStateMachine.Enter<LoadLevelState, int>(_progressService.Progress.CurrentLevel);
  }
}