using Code.Infrastructure.States;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Hud
{
  public class ReloadLevel : MonoBehaviour
  {
    [SerializeField] private Button _reloadLevelButton;
    private GameStateMachine _gameStateMachine;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine) => 
      _gameStateMachine = gameStateMachine;

    private void Awake() => 
      _reloadLevelButton.onClick.AddListener(ReloadLevelClick);

    private void ReloadLevelClick() => 
      _gameStateMachine.Enter<LoadLevelState, string>(SceneManager.GetActiveScene().name);
  }
}