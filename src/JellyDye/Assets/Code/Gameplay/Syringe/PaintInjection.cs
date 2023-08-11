using System.Collections;
using Code.Gameplay.Hud;
using Code.Services;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Fluxy;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Syringe
{
  public class PaintInjection : MonoBehaviour
  {
    //[SerializeField, Layer] private int _injectableLayer;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClipReset;
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private float _paintIncrease;
    [SerializeField] private float _paintIncrease2;
    [SerializeField] private float _paintRotationOverTime;
    [SerializeField] private float _maxPaintIncrease;
    [SerializeField] private Transform _pistonTransform;
    [SerializeField] private Transform _liquidTransform;
    [SerializeField] private float _pistonSpeed;
    [SerializeField] private float _liquidSpeed;
    [SerializeField] private float _movingCloserTime;
    [SerializeField] private float _movingLittleBackTime;
    [SerializeField] private float _movingBackTime;
    [SerializeField] private float _resetTime;
    [SerializeField, Range(0, 0.5f)] private float _movingCloserDistance;
    [SerializeField, Range(0, 0.2f)] private float _movingLittleBackDistance;
    [SerializeField] private float _pistonMovingDistance = 0.3f;
    [SerializeField] private float _minLiquidScaleY = 0.01f;

    private Vector3 _minPistonPosition;
    private Vector3 _injectionStartPosition;
    private Coroutine _paintCoroutine;
    private bool _isMovingBack;
    private Vector3 _pistonResetPosition;
    private float _liquidResetScale;
    private Vector3 _movingCloserDirection;
    private Vector2 _startTargetScale;
    private InjectionButton _injectionButton;
    private FluxyContainer _currentContainer;
    private Tween _moveTween;
    private int _injectableLayer;
    private FinishLevelService _finishLevelService;

    [Inject]
    public void Construct(FinishLevelService finishLevelService)
    {
      _finishLevelService = finishLevelService;
    }
    
    public void Initialize(InjectionButton injectionButton)
    {
      _injectionButton = injectionButton;
      _injectionButton.OnStartInjection += OnStartInjection;
      _injectionButton.OnStopInjection += OnStopInjection;
    }

    private void Awake()
    {
      _injectableLayer = 1 << LayerMask.NameToLayer("Injectable");
      _startTargetScale = _fluxyTarget.scale;
      _minPistonPosition = _pistonTransform.localPosition - Vector3.up * _pistonMovingDistance;
      _movingCloserDirection = transform.localRotation * Vector3.down;
      _pistonResetPosition = _pistonTransform.localPosition;
      _liquidResetScale = _liquidTransform.localScale.y;
    }

    private void OnDestroy()
    {
      _injectionButton.OnStartInjection -= OnStartInjection;
      _injectionButton.OnStopInjection -= OnStopInjection;
      _moveTween.Kill();
    }

    public void SyringeReset() =>
      StartCoroutine(Reset());

    private void OnStartInjection()
    {
      if (_isMovingBack)
        return;
      Vector3 currentSyringePosition = transform.position;
      _injectionStartPosition = currentSyringePosition;
      TweenerCore<Vector3, Vector3, VectorOptions> moveCloserTween = transform.DOMove(currentSyringePosition + _movingCloserDirection * _movingCloserDistance, _movingCloserTime);
      _moveTween = DOTween.Sequence()
        .Append(moveCloserTween)
        .Append(transform.DOMove(moveCloserTween.endValue - _movingCloserDirection * _movingLittleBackDistance, _movingLittleBackTime))
        .OnComplete(TryStartPaint);
    }

    private void OnStopInjection()
    {
      _moveTween.Kill();
      if (_paintCoroutine != null)
      {
        StopCoroutine(_paintCoroutine);
        _paintCoroutine = null;
      }

      if (_currentContainer != null)
        StopPainting();
      _isMovingBack = true;
      transform.DOMove(_injectionStartPosition, _movingBackTime)
        .OnComplete(() => _isMovingBack = false);
    }

    private void TryStartPaint()
    {
      if (!CanPainting())
        return;

      StartPainting();
      _paintCoroutine = StartCoroutine(Painting());
    }

    private IEnumerator Painting()
    {
      while (_injectionButton.IsInjecting)
      {
        if (_liquidTransform.localScale.y == _minLiquidScaleY)
        {
          StopPainting();
          SyringeReset();
          yield break;
        }

        if (_fluxyTarget.scale.x < _maxPaintIncrease)
          _fluxyTarget.scale += Vector2.one * (_paintIncrease * Time.deltaTime);
        else
          _fluxyTarget.scale += Vector2.one * (_paintIncrease2 * Time.deltaTime);

        _fluxyTarget.force = Quaternion.AngleAxis(_paintRotationOverTime * Time.deltaTime, Vector3.forward) * _fluxyTarget.force;
        MovePiston();
        MoveLiquid();
        yield return null;
      }
    }

    private bool CanPainting()
    {
      var origin = transform.position + Vector3.up * 0.5f;
      var direction = Vector3.down;
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

    private void StartPainting()
    {
      //Debug.Log("StartPainting");
      _currentContainer.targets.Add(_fluxyTarget);
      _fluxyTarget.enabled = true;
      if(!_finishLevelService.CanFinish)
        StartCoroutine(WaitForFirstPaint());
    }

    private IEnumerator WaitForFirstPaint()
    {
      yield return null;
      _finishLevelService.CheckPaint();
    }

    private void StopPainting()
    {
      _currentContainer.targets.Remove(_fluxyTarget);
      _currentContainer = null;
      _fluxyTarget.scale = _startTargetScale;
      _fluxyTarget.enabled = false;
    }

    private void MovePiston()
    {
      Vector3 pistonMovingDelta = Vector3.down * (_pistonSpeed * Time.deltaTime);
      if ((_pistonTransform.localPosition + pistonMovingDelta).y >= _minPistonPosition.y)
        _pistonTransform.localPosition += pistonMovingDelta;
      else
        _pistonTransform.localPosition = _minPistonPosition;
    }

    private void MoveLiquid()
    {
      Vector3 liquidMovingDelta = Vector3.down * (_pistonSpeed * _liquidSpeed * Time.deltaTime);
      if ((_liquidTransform.localScale + liquidMovingDelta).y >= _minLiquidScaleY)
        _liquidTransform.localScale += liquidMovingDelta;
      else
        _liquidTransform.localScale = new Vector3(_liquidTransform.localScale.x, _minLiquidScaleY, _liquidTransform.localScale.z);
    }

    private IEnumerator Reset()
    {
      _audioSource.PlayOneShot(_audioClipReset);
      _pistonTransform.localPosition = _minPistonPosition;
      _liquidTransform.localScale = new Vector3(1, _minLiquidScaleY, 1);

      Vector3 liquidResetScale = new Vector3(_liquidTransform.localScale.x, _liquidResetScale, _liquidTransform.localScale.z);
      for (float currentTime = 0; currentTime < _resetTime; currentTime += Time.deltaTime)
      {
        _pistonTransform.localPosition = Vector3.Lerp(_pistonTransform.localPosition, _pistonResetPosition, currentTime / _resetTime);
        _liquidTransform.localScale = Vector3.Lerp(_liquidTransform.localScale, liquidResetScale, currentTime / _resetTime);
        yield return null;
      }

      _pistonTransform.localPosition = _pistonResetPosition;
      _liquidTransform.localScale = liquidResetScale;
    }
  }
}