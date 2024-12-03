using Code.Enums;
using Code.UI.Hud;
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
      _injectionButton.OnButtonDown += OnInjectionButtonDown;
      _injectionButton.OnButtonUp += OnInjectionButtonUp;
    }

    private void OnDestroy()
    {
      _injectionButton.OnButtonDown -= OnInjectionButtonDown;
      _injectionButton.OnButtonUp -= OnInjectionButtonUp;
    }

    private void OnInjectionButtonDown()
    {
      if (_syringeAnimation.IsPlaying)
      {
        _syringeAnimation.StopAnimation();
        transform.position = _injectionStartPosition;
      }

      _injectionStartPosition = transform.position;
      _syringeAnimation.AnimateInjection(onComplete: _syringePainting.TryStartPaint);
    }

    private void OnInjectionButtonUp()
    {
      _syringeAnimation.StopAnimation();
      _syringeAnimation.AnimateMovingBack(_injectionStartPosition);
    }
  }
}