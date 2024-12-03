using Code.Enums;
using Code.UI.Hud;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class Syringe : MonoBehaviour
  {
    [SerializeField] private SyringeAnimation _syringeAnimation;
    [SerializeField] private SyringePainting _syringePainting;
    [SerializeField] private SyringePistonAndLiquid _syringePistonAndLiquid;
    [SerializeField] private SyringeMove _syringeMove;

    private Vector3 _injectionStartPosition;
    private InjectionButton _injectionButton;

    public SkinType SkinType { get; set; }

    public void Initialize(InjectionButton injectionButton)
    {
      _syringePainting.Initialize(injectionButton);
      _syringePistonAndLiquid.Initialize(injectionButton);
      _syringeMove.Initialize(injectionButton);

      _injectionButton = injectionButton;
      _injectionButton.OnButtonDown += UniTask.Action(OnInjectionButtonDown);
      _injectionButton.OnButtonUp += OnInjectionButtonUp;
    }

    private void OnDestroy()
    {
      _injectionButton.OnButtonDown -= UniTask.Action(OnInjectionButtonDown);
      _injectionButton.OnButtonUp -= OnInjectionButtonUp;
    }

    private async UniTaskVoid OnInjectionButtonDown()
    {
      _syringeAnimation.CompleteMoveBackIfPlaying();
      _injectionStartPosition = transform.position;
      await _syringeAnimation.AwaitAnimateInjectionComplete();
      _syringePainting.TryStartPaint();
    }

    private void OnInjectionButtonUp()
    {
      _syringeAnimation.StopInjectionAnimationIfPlaying();
      _syringeAnimation.AnimateMovingBack(_injectionStartPosition).Forget();
    }
  }
}