using System.Collections.Generic;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.StaticData.Level;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.MainMenuWindow.Gallery
{
  public class LevelsGrid : MonoBehaviour
  {
    [SerializeField] private GridLayoutGroup _gridLayoutGroup;
    [SerializeField] private float _offsetScrollMoveToProgress;

    private LevelButtonFactory _levelButtonFactory;
    private StaticDataService _staticData;
    private ProgressService _progress;
    private Dictionary<string, LevelButton> _levelButtons;

    [Inject]
    public void Construct(LevelButtonFactory levelButtonFactory, StaticDataService staticDataService, ProgressService progressService)
    {
      _progress = progressService;
      _staticData = staticDataService;
      _levelButtonFactory = levelButtonFactory;
    }

    private LevelConfig[] LevelConfigs => _staticData.ForLevels.LevelConfigs;

    private void Awake()
    {
      _levelButtons = new(LevelConfigs.Length);
      _progress.ForLevels.CompletedLevelsChanged += UpdateLevelData;
      InitLevelsGrid().Forget();
    }

    private void OnEnable() =>
      MoveScrollToCurrentLevel();

    private async UniTaskVoid InitLevelsGrid()
    {
      for (int i = 0; i < LevelConfigs.Length; i++)
      {
        LevelButton levelButton = await _levelButtonFactory.CreateLevelButton(transform);
        string levelId = LevelConfigs[i].Id;
        levelButton.Initialize(levelId, i);
        _levelButtons[levelId] = levelButton;
      }
    }

    private void UpdateLevelData(string levelId) =>
      _levelButtons[levelId].SetButtonData();

    private void MoveScrollToCurrentLevel()
    {
      string currentLevelId = _progress.ForLevels.CurrentLevelId;
      int currentIndex = _staticData.ForLevels.GetLevelIndex(currentLevelId);

      int columns = Mathf.Max(1, _gridLayoutGroup.constraintCount); // количество колонок
      int row = currentIndex / columns;

      float cellHeight = _gridLayoutGroup.cellSize.y + _gridLayoutGroup.spacing.y;

      RectTransform contentRect = (RectTransform)transform;
      float contentHeight = contentRect.rect.height;
      float viewportHeight = ((RectTransform)_gridLayoutGroup.transform.parent).rect.height;
      
      float movingHeight = row * cellHeight - _offsetScrollMoveToProgress;
      float maxScroll = Mathf.Max(0, contentHeight - viewportHeight);

      movingHeight = Mathf.Clamp(movingHeight, 0, maxScroll);

      contentRect.anchoredPosition = Vector2.up * movingHeight;
    }
  }
}
