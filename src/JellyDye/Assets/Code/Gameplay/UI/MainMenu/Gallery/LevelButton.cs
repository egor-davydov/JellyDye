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
    [SerializeField] private Button _loadLevelButton;
    [SerializeField] private TextMeshProUGUI _levelNumber;
    [SerializeField] private TextMeshProUGUI _levelPercentage;
    [SerializeField, Range(0, 100)] private int _yellowPercentage;
    [SerializeField, Range(0, 100)] private int _redPercentage;

    private GameStateMachine _gameStateMachine;
    private int _levelIndex;
    private ProgressService _progressService;
    private Color GreenPercentageColor => new(0.5f, 1, 0.5f, 1);
    private Color YellowPercentageColor => new(1, 1, 0.5f, 1);
    private Color RedPercentageColor => new(1, 0.5f, 0.5f, 1);

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
        int percentage = progressLevelData.CompletedLevel(_levelIndex).Percentage;
        
        _levelPercentage.gameObject.SetActive(true);
        _levelNumber.gameObject.SetActive(false);
        _levelPercentage.text = $"{percentage}\n%";
        Color levelPercentageColor;
        if(percentage > _yellowPercentage)
        {
          levelPercentageColor = GreenPercentageColor;
        }
        else
        {
          levelPercentageColor = percentage > _redPercentage
            ? YellowPercentageColor
            : RedPercentageColor;
        }
        
        _levelPercentage.color = levelPercentageColor;
        _levelPercentage.outlineColor = levelPercentageColor;
      }
      else
        _levelNumber.text = (_levelIndex + 1).ToString();
    }

    private void Awake() =>
      _loadLevelButton.onClick.AddListener(LoadLevelClick);

    private bool LevelCompleted(CompletedLevel observableLevel) => 
      observableLevel != default;

    private void LoadLevelClick() => 
      _gameStateMachine.Enter<LoadLevelState, int>(_levelIndex);
  }
}