using Code.Data;
using Code.Infrastructure.States;
using Code.Services;
using Code.Services.Progress;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Gallery
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

    private GameStateMachine _gameStateMachine;
    private string _levelId;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, ProgressService progressService,
      StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
      _progressService = progressService;
      _gameStateMachine = gameStateMachine;
    }

    public void Initialize(string levelId, int levelIndex)
    {
      _levelId = levelId;
      LevelData progressLevelData = _progressService.Progress.LevelData;
      if (!progressLevelData.IsLevelCompleted(_levelId))
      {
        UnCompletedTurnOn(true);
        NotFullCompletedTurnOn(false);
        FullCompletedTurnOn(false);
        _levelNumber.text = (levelIndex + 1).ToString();
      }
      else
      {
        int percentage = progressLevelData.CompletedLevel(_levelId).Percentage;
        if (percentage == 100)
        {
          SetBackground(_backgroundFullCompleted);
          UnCompletedTurnOn(false);
          NotFullCompletedTurnOn(false);
          FullCompletedTurnOn(true);
          _levelJellyTexture.texture = _staticDataService.ForLevels().LevelConfigs[levelIndex].TargetTexture;
          return;
        }

        SetBackground(_backgroundNotFullCompleted);
        UnCompletedTurnOn(false);
        NotFullCompletedTurnOn(true);
        FullCompletedTurnOn(false);
        _levelPercentage.text = $"{percentage}\n%";
        _levelNumberWithPercentage.text = (levelIndex + 1).ToString();
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

    private void Awake() =>
      _loadLevelButton.onClick.AddListener(LoadLevelClick);

    private bool LevelCompleted(CompletedLevel observableLevel) => 
      observableLevel != default;

    private void LoadLevelClick() => 
      _gameStateMachine.Enter<LoadLevelState, string>(_levelId);
  }
}