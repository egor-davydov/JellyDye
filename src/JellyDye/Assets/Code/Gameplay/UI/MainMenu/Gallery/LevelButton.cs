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
    [SerializeField] private RawImage _resultImage;
    [SerializeField] private Button _loadLevelButton;
    [SerializeField] private TextMeshProUGUI _levelNumber;
    [SerializeField] private Sprite _levelCompletedSprite;

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
        CompletedLevel completedLevel = progressLevelData.CompletedLevel(_levelIndex);

        _resultImage.texture = ConvertToTexture(completedLevel.ResultImage);
        SwitchButtonViewToComplete(true);
      }
      else
      {
        SwitchButtonViewToComplete(false);
        _levelNumber.text = (_levelIndex + 1).ToString();
      }
    }

    private Texture2D ConvertToTexture(string resultImage)
    {
      byte[] fromBase64String = Convert.FromBase64String(resultImage);
      Texture2D temporaryTexture = new Texture2D(1, 1);
      temporaryTexture.LoadImage(fromBase64String);

      return temporaryTexture;
    }

    private void SwitchButtonViewToComplete(bool value)
    {
      _resultImage.gameObject.SetActive(value);
      _levelNumber.gameObject.SetActive(!value);
    }
    
    private void Awake() =>
      _loadLevelButton.onClick.AddListener(LoadLevelClick);

    private bool LevelCompleted(CompletedLevel observableLevel) => 
      observableLevel != default;

    private void LoadLevelClick() => 
      _gameStateMachine.Enter<LoadLevelState, int>(_levelIndex);
  }
}