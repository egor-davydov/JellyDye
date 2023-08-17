using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.StaticData;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Gallery
{
  public class LevelsGrid : MonoBehaviour
  {
    [SerializeField] private GridLayoutGroup _gridLayoutGroup;
    
    private LevelButtonFactory _levelButtonFactory;
    private StaticDataService _staticDataService;
    private ProgressService _progressService;

    [Inject]
    public void Construct(LevelButtonFactory levelButtonFactory, StaticDataService staticDataService, ProgressService progressService)
    {
      _progressService = progressService;
      _staticDataService = staticDataService;
      _levelButtonFactory = levelButtonFactory;
    }

    private void Awake()
    {
      LevelConfig[] levelConfigs = _staticDataService.ForLevels().LevelConfigs;
      for (int i = 0; i < levelConfigs.Length; i++)
      {
        GameObject levelButtonObject = _levelButtonFactory.CreateLevelButton(transform);
        levelButtonObject.GetComponent<LevelButton>().Initialize(i);
      }

      MoveScrollToCurrentLevel();
    }

    private void MoveScrollToCurrentLevel()
    {
      int levelRow = _progressService.Progress.LevelData.CurrentLevelIndex / 2;
      ((RectTransform)transform).anchoredPosition += Vector2.up * levelRow * (_gridLayoutGroup.cellSize.y + _gridLayoutGroup.spacing.y);
    }
  }
}