using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.StaticData.Level;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Gallery
{
  public class LevelsGrid : MonoBehaviour
  {
    [SerializeField] private GridLayoutGroup _gridLayoutGroup;
    [SerializeField] private float _offsetScrollMoveToProgress;
    [SerializeField] private float _screenSize;

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
      InitLevelsGrid().Forget();
    }

    private async UniTaskVoid InitLevelsGrid()
    {
      LevelConfig[] levelConfigs = _staticDataService.Levels.LevelConfigs;
      for (int i = 0; i < levelConfigs.Length; i++)
      {
        LevelButton levelButton = await _levelButtonFactory.CreateLevelButton(transform);
        levelButton.Initialize(levelConfigs[i].Id, i);
      }

      MoveScrollToCurrentLevel(levelConfigs.Length);
    }

    private void MoveScrollToCurrentLevel(int levelsCount)
    {
      string currentLevelId = _progressService.Progress.LevelData.CurrentLevelId;
      int levelRow = _staticDataService.Levels.GetLevelIndex(currentLevelId) / 2;
      float sizeOfLevelButtonWithSpacing = _gridLayoutGroup.cellSize.y + _gridLayoutGroup.spacing.y;
      int rowsCount = Mathf.RoundToInt((float)levelsCount / 2);
      float scrollHeight = sizeOfLevelButtonWithSpacing * rowsCount;

      float movingHeight = levelRow * sizeOfLevelButtonWithSpacing - _offsetScrollMoveToProgress;
      movingHeight = Mathf.Clamp(movingHeight, 0, scrollHeight - Screen.height);
      ((RectTransform)transform).anchoredPosition = Vector2.up * movingHeight;
    }
  }
}