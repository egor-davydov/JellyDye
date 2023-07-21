using Code.Infrastructure.States;
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
    
    private GameStateMachine _gameStateMachine;
    private int _levelIndex;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine) => 
      _gameStateMachine = gameStateMachine;

    public void Initialize(int levelIndex)
    {
      _levelIndex = levelIndex;
      _levelNumber.text = _levelIndex.ToString();
    }

    private void Awake() => 
      _loadLevelButton.onClick.AddListener(LoadLevelClick);

    private void LoadLevelClick()
    {
      _gameStateMachine.Enter<LoadLevelState, int>(_levelIndex);
    }
  }
}