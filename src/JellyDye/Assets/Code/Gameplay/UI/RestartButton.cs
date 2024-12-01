using Code.Infrastructure.States;
using Code.Services.Progress;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI
{
  public class RestartButton : MonoBehaviour
  {
    [SerializeField] private Button _reloadLevelButton;
    [SerializeField] private float _rotationAnimationDuration = 0.5f;

    private GameStateMachine _gameStateMachine;
    private ProgressService _progress;
    private Tween _rotationAnimation;

    [Inject]
    public void Construct(GameStateMachine gameStateMachine, ProgressService progressService)
    {
      _progress = progressService;
      _gameStateMachine = gameStateMachine;
    }

    private void Awake()
    {
      _reloadLevelButton.onClick.AddListener(UniTask.UnityAction(RestartLevelClick));
      _rotationAnimation = transform.DORotate(Vector3.forward * 360, _rotationAnimationDuration, RotateMode.FastBeyond360)
        .SetEase(Ease.Linear).SetLink(gameObject).SetAutoKill(false);
    }

    private async UniTaskVoid RestartLevelClick()
    {
      _reloadLevelButton.interactable = false;
      _gameStateMachine.Enter<LoadLevelState, string>(_progress.ForLevels.CurrentLevelId);
      _rotationAnimation.Restart();
      await _rotationAnimation.AwaitForComplete();
      _reloadLevelButton.interactable = true;
    }
  }
}