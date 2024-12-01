using Code.Gameplay.UI.Hud;
using Code.Services;
using Cysharp.Threading.Tasks;
using Fluxy;
using UnityEngine;
using Zenject;
using static Code.Constants.SyringeConstants;

namespace Code.Gameplay.Syringe
{
  public class SyringePainting : MonoBehaviour
  {
    [SerializeField] private SyringeAudio _syringeAudio;
    [SerializeField] private SyringePistonAndLiquid _syringePistonAndLiquid;
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private float _pistonSpeed;
    [SerializeField] private float _paintIncreaseSpeed;
    [SerializeField] private float _paintRotationSpeed;
    [SerializeField] private float _targetForcePower;
    [SerializeField] private Vector2 _startForceDirection;

    private FluxyContainer _currentContainer;
    private Vector2 _startTargetScale;
    private int _injectableLayer;
    private Vector3 _currentForceDirection;

    private FinishButtonService _finishButtonService;
    private InjectionButton _injectionButton;

    [Inject]
    public void Construct(FinishButtonService finishButtonService)
    {
      _finishButtonService = finishButtonService;
    }

    public void Initialize(InjectionButton injectionButton)
    {
      _injectionButton = injectionButton;
      _injectionButton.OnButtonUp += OnInjectionButtonUp;
    }

    private void Awake()
    {
      _fluxyTarget.force = _startForceDirection;
      _injectableLayer = 1 << LayerMask.NameToLayer("Injectable");
      _startTargetScale = _fluxyTarget.scale;
    }

    private void OnDestroy()
    {
      _injectionButton.OnButtonUp -= OnInjectionButtonUp;
    }

    private void OnInjectionButtonUp()
    {
      if (IsPainting()) // Check if stopped because no paint in syringe
        StopPainting();
    }

    public void TryStartPaint()
    {
      if (!CanPainting())
        return;

      StartPainting();
    }

    private void StartPainting()
    {
      _syringeAudio.PlayFill();
      _currentContainer.targets.Add(_fluxyTarget);
      SetActiveTarget(true);

      PaintAsync().Forget();
      _currentContainer.HasPaint = true;
      if (!_finishButtonService.FinishButtonAnimated)
        _finishButtonService.CreateFinishButtonIfAllMeshesPainted();
    }

    private void StopPainting()
    {
      _syringeAudio.PlayFillEnd();
      _currentContainer.targets.Remove(_fluxyTarget);
      _currentContainer = null;
      _fluxyTarget.scale = _startTargetScale;
      _fluxyTarget.force = _currentForceDirection * _targetForcePower;
      SetActiveTarget(false);
    }

    private async UniTask PaintAsync()
    {
      float additionalIncreaseSpeed = _currentContainer.AdditionalPaintIncreaseSpeed;
      float forcePlusAdditional = _targetForcePower + additionalIncreaseSpeed;
      while (_injectionButton.IsInjecting)
      {
        if (_syringePistonAndLiquid.IsLiquidRunOut())
        {
          StopPainting();
          _syringePistonAndLiquid.ResetEither().Forget();
          break;
        }

        _fluxyTarget.scale +=
          Vector2.one * ((_paintIncreaseSpeed + additionalIncreaseSpeed) * Time.deltaTime);
        _currentForceDirection =
          Quaternion.AngleAxis(_paintRotationSpeed * Time.deltaTime, Vector3.forward) * _fluxyTarget.force.normalized;
        _fluxyTarget.force = _currentForceDirection * forcePlusAdditional;
        _syringePistonAndLiquid.MovePiston((_pistonSpeed * Time.deltaTime));
        _syringePistonAndLiquid.MoveLiquid((_pistonSpeed * LiquidSpeed * Time.deltaTime));
        await UniTask.Yield(destroyCancellationToken);
      }
    }

    public bool IsPainting() =>
      _currentContainer != null;

    private bool CanPainting()
    {
      Vector3 origin = transform.position + Vector3.up * 0.5f;
      Vector3 direction = InjectionDirection;
      //Debug.DrawRay(origin, direction, Color.red, 20);

      if (!Physics.Raycast(origin, direction, out RaycastHit hit, 1, _injectableLayer))
        return false;
      Transform softbody = hit.collider.transform.parent;
      //Debug.Log(hit.collider.name);
      if (softbody == null)
        return false;
      _currentContainer = softbody.GetComponentInChildren<FluxyContainer>();
      if (_currentContainer == null)
        return false;

      return true;
    }

    private void SetActiveTarget(bool isActive) =>
      _fluxyTarget.gameObject.SetActive(isActive);
  }
}