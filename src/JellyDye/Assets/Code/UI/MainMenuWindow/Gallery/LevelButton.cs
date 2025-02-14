using Code.Data;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.Progress;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.MainMenuWindow.Gallery
{
  public class LevelButton : MonoBehaviour
  {
    [SerializeField] private Button _loadLevelButton;
    [SerializeField] private Image _backgroundImage;
    [SerializeField] private TextMeshProUGUI _levelNumber;
    [SerializeField] private TextMeshProUGUI _levelNumberWithPercentage;
    [SerializeField] private TextMeshProUGUI _levelPercentage;
    [SerializeField] private Sprite _backgroundNotFullCompleted;
    [SerializeField, Range(0, 100)] private int _yellowPercentage;
    [SerializeField, Range(0, 100)] private int _redPercentage;
    [SerializeField] private Color _greenPercentageColor;
    [SerializeField] private Color _yellowPercentageColor;
    [SerializeField] private Color _redPercentageColor;

    [SerializeField] private RawImage _levelJellyTexture;
    [SerializeField] private Sprite _backgroundFullCompleted;

    private int _levelIndex;
    private string _levelId;

    private GameStateMachine _gameStateMachine;
    private ProgressService _progress;
    private StaticDataService _staticData;
    private StringsService _stringsService;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, ProgressService progressService,
      StaticDataService staticDataService, StringsService stringsService, WindowsService windowsService)
    {
      _stringsService = stringsService;
      _staticData = staticDataService;
      _progress = progressService;
      _gameStateMachine = gameStateMachine;
    }

    public void Initialize(string levelId, int levelIndex)
    {
      _levelIndex = levelIndex;
      _levelId = levelId;
      SetButtonData();
    }

    private void Awake() =>
      _loadLevelButton.onClick.AddListener(LoadLevelClick);

    public void SetButtonData()
    {
      if (!_progress.ForLevels.IsLevelAlreadyInProgress(_levelId))
      {
        UnCompletedTurnOn(true);
        NotFullCompletedTurnOn(false);
        FullCompletedTurnOn(false);
        _levelNumber.text = _staticData.ForDevelopHelpers.IsShowingNames
          ? _levelId
          : _stringsService.Numbers[_levelIndex + 1];
      }
      else
      {
        int percentage = _progress.ForLevels.CompletedLevel(_levelId).Percentage;
        if (percentage == 100)
        {
          SetBackground(_backgroundFullCompleted);
          UnCompletedTurnOn(false);
          NotFullCompletedTurnOn(false);
          FullCompletedTurnOn(true);
          _levelJellyTexture.texture = _staticData.ForLevels.LevelConfigs[_levelIndex].TargetTexture;
          return;
        }

        SetBackground(_backgroundNotFullCompleted);
        UnCompletedTurnOn(false);
        NotFullCompletedTurnOn(true);
        FullCompletedTurnOn(false);
        _levelPercentage.text = _stringsService.PercentagesWithNewLine[percentage];
        _levelNumberWithPercentage.text = _stringsService.Numbers[_levelIndex + 1];
        Color levelPercentageColor = PercentageColor(percentage);

        _levelPercentage.color = levelPercentageColor;
      }
    }

    private void SetBackground(Sprite backgroundSprite) =>
      _backgroundImage.sprite = backgroundSprite;

    private void UnCompletedTurnOn(bool value) =>
      _levelNumber.gameObject.SetActive(value);

    private void NotFullCompletedTurnOn(bool value)
    {
      _levelPercentage.gameObject.SetActive(value);
      _levelNumberWithPercentage.gameObject.SetActive(value);
    }

    private void FullCompletedTurnOn(bool value) =>
      _levelJellyTexture.gameObject.SetActive(value);

    private Color PercentageColor(int percentage)
    {
      Color levelPercentageColor;
      if (percentage > _yellowPercentage)
      {
        levelPercentageColor = _greenPercentageColor;
      }
      else
      {
        levelPercentageColor = percentage > _redPercentage
          ? _yellowPercentageColor
          : _redPercentageColor;
      }

      return levelPercentageColor;
    }

    private bool LevelCompleted(CompletedLevel observableLevel) =>
      observableLevel != default;

    private void LoadLevelClick() =>
      _gameStateMachine.Enter<LoadLevelState, string>(_levelId);
  }
}