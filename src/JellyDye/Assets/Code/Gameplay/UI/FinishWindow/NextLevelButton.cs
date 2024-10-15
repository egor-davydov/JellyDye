using System.Linq;
using Code.Data;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.StaticData;
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
    private StaticDataService _staticDataService;
    private ProgressService _progressService;
    private WindowFactory _windowFactory;
    private LevelData _progressLevelData;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      ProgressService progressService, WindowFactory windowFactory)
    {
      _windowFactory = windowFactory;
      _progressService = progressService;
      _staticDataService = staticDataService;
      _gameStateMachine = gameStateMachine;
      
      _progressLevelData = _progressService.Progress.LevelData;
    }
    private void Awake() => 
      _nextLevelButton.onClick.AddListener(OnNextLevelButtonClick);

    private void OnNextLevelButtonClick()
    {
      LevelsStaticData levelsStaticData = _staticDataService.ForLevels();
      int currentLevelIndex = levelsStaticData.GetLevelIndex(_progressLevelData.CurrentLevelId);
      int? nextLevelIndex = GetNextLevelIndex(currentLevelIndex);
      int lastLevelIndex = levelsStaticData.LevelConfigs.Length - 1;
      if (nextLevelIndex == null)
      {
        if(currentLevelIndex == lastLevelIndex)
          _windowFactory.CreateMainMenu().Forget();
        else
          LoadLevel(currentLevelIndex + 1, levelsStaticData);
      }
      else
        LoadLevel(nextLevelIndex.Value, levelsStaticData);
    }

    private void LoadLevel(int levelIndex, LevelsStaticData levelsStaticData) => 
      _gameStateMachine.Enter<LoadLevelState, string>(levelsStaticData.LevelConfigs[levelIndex].Id);

    private int? GetNextLevelIndex(int currentLevelIndex)
    {
      LevelConfig[] levelConfigs = _staticDataService.ForLevels().LevelConfigs;
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
        CompletedLevel completedLevel = _progressLevelData.CompletedLevels.FirstOrDefault(level => level.Id == levelConfig.Id);
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