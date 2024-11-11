using Code.Infrastructure.States;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.Hud
{
  public class FinishButton : MonoBehaviour
  {
    [SerializeField] private Button _finishButton;

    private GameStateMachine _gameStateMachine;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine)
    {
      _gameStateMachine = gameStateMachine;
    }

    private void Awake() =>
      _finishButton.onClick.AddListener(FinishLevel);

    private void FinishLevel() =>
      _gameStateMachine.Enter<FinishLevelState>();
  }
}