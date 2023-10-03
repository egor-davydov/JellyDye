using Code.Infrastructure.States;
using Code.Services;
using Code.Services.Progress;
using Code.StaticData;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class NextLevelButton : MonoBehaviour
  {
    [SerializeField] private Button _nextLevelButton;
    private GameStateMachine _gameStateMachine;
    private StaticDataService _staticDataService;
    private ProgressService _progressService;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      ProgressService progressService)
    {
      _progressService = progressService;
      _staticDataService = staticDataService;
      _gameStateMachine = gameStateMachine;
    }
    private void Awake() => 
      _nextLevelButton.onClick.AddListener(OnNextLevelButtonClick);

    private void OnNextLevelButtonClick()
    {
      LevelsStaticData levelsStaticData = _staticDataService.ForLevels();
      int currentLevelIndex = levelsStaticData.GetLevelIndex(_progressService.Progress.LevelData.CurrentLevelId);
      _gameStateMachine.Enter<LoadLevelState, string>(levelsStaticData.LevelConfigs[currentLevelIndex+1].Id);
    }
  }
}