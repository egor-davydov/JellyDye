using Code.UI.Hud;
using Cysharp.Threading.Tasks;
using UnityEngine;
using static Code.Constants.SyringeConstants;

namespace Code.Gameplay.Syringe
{
  public class SyringePistonAndLiquid : MonoBehaviour
  {
    [SerializeField] private float _pistonMovingDistance;
    [SerializeField] private float _minLiquidScaleY;
    [SerializeField] private float _resetTime;
    [SerializeField] private float _liquidScaleYToResetOnStop;

    private Transform _pistonTransform;
    private Transform _liquidTransform;

    private Vector3 _minPistonPosition;
    private Vector3 _pistonResetPosition;
    private Vector3 _liquidResetScale;
    private InjectionButton _injectionButton;

    public void WireUp(Transform pistonTransform, Transform liquidTransform)
    {
      _pistonTransform = pistonTransform;
      _liquidTransform = liquidTransform;

      _minPistonPosition = _pistonTransform.localPosition + InjectionDirection * _pistonMovingDistance;
      _pistonResetPosition = _pistonTransform.localPosition;
      _liquidResetScale = _liquidTransform.localScale;
    }

    public void Initialize(InjectionButton injectionButton)
    {
      _injectionButton = injectionButton;
      _injectionButton.OnButtonUp += OnInjectionButtonUp;
    }

    private void OnDestroy()
    {
      _injectionButton.OnButtonUp -= OnInjectionButtonUp;
    }

    private void OnInjectionButtonUp()
    {
      if (_liquidTransform.localScale.y <= _liquidScaleYToResetOnStop)
        ResetEither(fromMinPositions: false).Forget();
    }

    public bool IsLiquidRunOut() => // ReSharper disable once CompareOfFloatsByEqualityOperator
      _liquidTransform.localScale.y == _minLiquidScaleY;

    public void MovePiston(float moveDistance)
    {
      Vector3 moveVector = InjectionDirection * moveDistance;
      if ((_pistonTransform.localPosition + moveVector).y >= _minPistonPosition.y)
        _pistonTransform.localPosition += moveVector;
      else
        _pistonTransform.localPosition = _minPistonPosition;
    }

    public void MoveLiquid(float moveDistance)
    {
      Vector3 moveVector = InjectionDirection * moveDistance;
      if ((_liquidTransform.localScale + moveVector).y >= _minLiquidScaleY)
        _liquidTransform.localScale += moveVector;
      else
        _liquidTransform.localScale =
          new Vector3(_liquidTransform.localScale.x, _minLiquidScaleY, _liquidTransform.localScale.z);
    }

    public async UniTaskVoid ResetEither(bool fromMinPositions = true)
    {
      if (fromMinPositions)
      {
        _pistonTransform.localPosition = _minPistonPosition;
        _liquidTransform.localScale = new Vector3(1, _minLiquidScaleY, 1);
      }

      for (float currentTime = 0; currentTime < _resetTime; currentTime += Time.deltaTime)
      {
        _pistonTransform.localPosition =
          Vector3.Lerp(_pistonTransform.localPosition, _pistonResetPosition, currentTime / _resetTime);
        _liquidTransform.localScale =
          Vector3.Lerp(_liquidTransform.localScale, _liquidResetScale, currentTime / _resetTime);
        await UniTask.Yield(destroyCancellationToken);
      }

      _pistonTransform.localPosition = _pistonResetPosition;
      _liquidTransform.localScale = _liquidResetScale;
    }
  }
}