using Code.Infrastructure.States;
using Code.Services.Progress;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.Hud
{
  public class ReloadLevel : MonoBehaviour
  {
    [SerializeField] private Button _reloadLevelButton;
    private GameStateMachine _gameStateMachine;
    private ProgressService _progress;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, ProgressService progressService)
    {
      _progress = progressService;
      _gameStateMachine = gameStateMachine;
    }

    private void Awake() =>
      _reloadLevelButton.onClick.AddListener(ReloadLevelClick);

    private void ReloadLevelClick() =>
      _gameStateMachine.Enter<LoadLevelState, string>(_progress.ForLevels.CurrentLevelId);
  }
}