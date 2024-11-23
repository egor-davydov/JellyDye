using System.Linq;
using Code.Data;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.StaticData.Level;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class NextLevelButton : MonoBehaviour
  {
    [SerializeField] private Button _nextLevelButton;
    private GameStateMachine _gameStateMachine;
    private StaticDataService _staticData;
    private ProgressService _progress;
    private WindowFactory _windowFactory;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      ProgressService progressService, WindowFactory windowFactory)
    {
      _windowFactory = windowFactory;
      _progress = progressService;
      _staticData = staticDataService;
      _gameStateMachine = gameStateMachine;
    }

    private void Awake() =>
      _nextLevelButton.onClick.AddListener(OnNextLevelButtonClick);

    private void OnNextLevelButtonClick()
    {
      int currentLevelIndex = _staticData.ForLevels.GetLevelIndex(_progress.ForLevels.CurrentLevelId);
      int? nextLevelIndex = GetNextLevelIndex(currentLevelIndex);
      int lastLevelIndex = _staticData.ForLevels.LevelConfigs.Length - 1;
      if (nextLevelIndex == null)
      {
        if (currentLevelIndex == lastLevelIndex)
          _windowFactory.CreateMainMenu().Forget();
        else
          LoadLevel(currentLevelIndex + 1);
      }
      else
        LoadLevel(nextLevelIndex.Value);
    }

    private void LoadLevel(int levelIndex) =>
      _gameStateMachine.Enter<LoadLevelState, string>(_staticData.ForLevels.LevelConfigs[levelIndex].Id);

    private int? GetNextLevelIndex(int currentLevelIndex)
    {
      LevelConfig[] levelConfigs = _staticData.ForLevels.LevelConfigs;
      int? futureLevelIndex = FindUnCompletedLevelIndex(currentLevelIndex + 1, levelConfigs.Length, levelConfigs);
      if (futureLevelIndex != null)
        return futureLevelIndex.Value;

      int? previousLevelIndex = FindUnCompletedLevelIndex(0, currentLevelIndex + 1, levelConfigs);
      if (previousLevelIndex != null)
        return previousLevelIndex.Value;

      return null;
    }

    private int? FindUnCompletedLevelIndex(int from, int to, LevelConfig[] levelConfigs)
    {
      for (int i = from; i < to; i++)
      {
        LevelConfig levelConfig = levelConfigs[i];
        CompletedLevel completedLevel = _progress.ForLevels.CompletedLevels.FirstOrDefault(level => level.Id == levelConfig.Id);
        if (completedLevel == default)
          return i;
        if (completedLevel.Percentage == 100)
          continue;

        return i;
      }

      return null;
    }
  }
}