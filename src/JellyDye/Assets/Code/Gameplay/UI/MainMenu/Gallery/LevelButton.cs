using System;
using System.Linq;
using Code.Data;
using Code.Infrastructure.States;
using Code.Services.Progress;
using ModestTree;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Gallery
{
  public class LevelButton : MonoBehaviour
  {
    [SerializeField] private Image _backgroundImage;
    [SerializeField] private Button _loadLevelButton;
    [SerializeField] private TextMeshProUGUI _levelNumber;
    [SerializeField] private TextMeshProUGUI _levelPercentage;
    [SerializeField] private Sprite _levelCompletedSprite;
    [SerializeField, Range(0, 100)] private int _yellowPercentage;
    [SerializeField, Range(0, 100)] private int _redPercentage;
    [SerializeField] private Color _greenPercentageColor; 
    [SerializeField] private Color _yellowPercentageColor;
    [SerializeField] private Color _redPercentageColor;

    private GameStateMachine _gameStateMachine;
    private int _levelIndex;
    private ProgressService _progressService;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, ProgressService progressService)
    {
      _progressService = progressService;
      _gameStateMachine = gameStateMachine;
    }

    public void Initialize(int levelIndex)
    {
      _levelIndex = levelIndex;
      LevelData progressLevelData = _progressService.Progress.LevelData;
      if (progressLevelData.IsLevelCompleted(_levelIndex))
      {
        _backgroundImage.sprite = _levelCompletedSprite;
        int percentage = progressLevelData.CompletedLevel(_levelIndex).Percentage;
        
        _levelPercentage.gameObject.SetActive(true);
        _levelNumber.gameObject.SetActive(false);
        _levelPercentage.text = $"{percentage}\n%";
        Color levelPercentageColor = PercentageColor(percentage);

        _levelPercentage.color = levelPercentageColor;
      }
      else
        _levelNumber.text = (_levelIndex + 1).ToString();
    }

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
      _gameStateMachine.Enter<LoadLevelState, int>(_levelIndex);
  }
}