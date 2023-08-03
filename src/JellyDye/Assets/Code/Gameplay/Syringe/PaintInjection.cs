using System.Collections;
using Code.Gameplay.Hud;
using Fluxy;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class PaintInjection : MonoBehaviour
  {
    [SerializeField] private SyringeMove _syringeMove;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClipReset;
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private float _paintIncreaseOverTime;
    [SerializeField] private float _paintRotationOverTime;
    [SerializeField] private Transform _pistonTransform;
    [SerializeField] private Transform _liquidTransform;
    [SerializeField] private float _pistonSpeed;
    [SerializeField] private float _liquidSpeed;
    [SerializeField] private float _movingCloserTime;
    [SerializeField] private float _movingBackTime;
    [SerializeField, Range(0, 2)] private float _movingCloserDistance = 1;
    [SerializeField, Range(0, 1)] private float _movingLittleBackDistance = 0.3f;
    [SerializeField] private float _movingLittleBackTime;
    [SerializeField] private float _resetTime;
    [SerializeField] private float _pistonMovingDistance = 0.3f;
    [SerializeField, Range(0, 0.1f)] private float _minLiquidScale = 0.01f;

    private const KeyCode InjectionKeyCode = KeyCode.Q;
    private Vector3 _minPistonPosition;

    private Vector3 _injectionStartPosition;
    private Coroutine _injectionCoroutine;
    private bool _isMovingBack;
    private Vector3 _pistonResetPosition;
    private float _liquidResetScale;
    private Vector3 _movingCloserDirection;
    private Vector2 _startTargetScale;
    private InjectionButton _injectionButton;
    private FluxyContainer _currentContainer;

    public void Initialize(InjectionButton injectionButton)
    {
      _injectionButton = injectionButton;
      _injectionButton.OnStartInjection += OnStartInjection;
      _injectionButton.OnStopInjection += OnStopInjection;
    }

    private void Awake()
    {
      _startTargetScale = _fluxyTarget.scale;
      _minPistonPosition = _pistonTransform.localPosition - Vector3.up * _pistonMovingDistance;
      _movingCloserDirection = transform.localRotation * Vector3.down;
      _pistonResetPosition = _pistonTransform.localPosition;
      _liquidResetScale = _liquidTransform.localScale.y;
    }

    private void Update()
    {
      if (!_injectionButton || _isMovingBack)
        return;

      if (Input.GetKeyDown(InjectionKeyCode))
      {
        OnStartInjection();
      }

      if (Input.GetKeyUp(InjectionKeyCode))
      {
        OnStopInjection();
      }
    }

    private void OnStartInjection()
    {
      _syringeMove.enabled = false;
      _injectionStartPosition = transform.position;
      _injectionCoroutine = StartCoroutine(Injection());
    }

    private void OnStopInjection()
    {
      _syringeMove.enabled = true;
      StopCoroutine(_injectionCoroutine);
      StopPaint();
      StartCoroutine(MoveBack());
    }

    public void SyringeReset() =>
      StartCoroutine(Reset());

    private IEnumerator Injection()
    {
      for (float currentTime = 0; currentTime < _movingCloserTime; currentTime += Time.deltaTime)
      {
        transform.position = Vector3.Lerp(transform.position, transform.position + _movingCloserDirection * _movingCloserDistance, currentTime / _movingCloserTime);
        yield return null;
      }

      for (float currentTime = 0; currentTime < _movingLittleBackTime; currentTime += Time.deltaTime)
      {
        transform.position = Vector3.Lerp(transform.position, transform.position - _movingCloserDirection * _movingLittleBackDistance, currentTime / _movingLittleBackTime);
        yield return null;
      }

      if (_liquidTransform.localScale.y > _minLiquidScale)
        StartPaint();
      while (Input.GetKey(InjectionKeyCode) || _injectionButton.IsInjecting)
      {
        if (_liquidTransform.localScale.y == _minLiquidScale)
        {
          StopPaint();
          SyringeReset();
          yield break;
        }

        _fluxyTarget.scale += Vector2.one * (_paintIncreaseOverTime * Time.deltaTime);
        _fluxyTarget.force = Quaternion.AngleAxis(_paintRotationOverTime * Time.deltaTime, Vector3.forward) * _fluxyTarget.force;
        _pistonTransform.localPosition += Vector3.down * (_pistonSpeed * Time.deltaTime);
        MoveLiquid(_liquidTransform.localScale, Vector3.down);
        yield return null;
      }
    }

    private void StartPaint()
    {
      var ray = new Ray(transform.position - (_movingCloserDirection *0.5f), _movingCloserDirection);
      //Debug.DrawRay(ray.origin, ray.direction, Color.red, 20);
      if (!Physics.Raycast(ray, out RaycastHit hit))
        return;
      if (hit.collider.transform.parent == null)
        return;
      _currentContainer = hit.collider.transform.parent.GetComponentInChildren<FluxyContainer>();
      if (_currentContainer == null)
        return;
      //Debug.Log("Successful");
      _currentContainer.targets.Add(_fluxyTarget);
      _fluxyTarget.enabled = true;
    }

    private void StopPaint()
    {
      if (_currentContainer == null)
        return;
      _currentContainer.targets.Remove(_fluxyTarget);
      _currentContainer = null;
      _fluxyTarget.scale = _startTargetScale;
      _fluxyTarget.enabled = false;
    }

    private void MoveLiquid(Vector3 liquidScale, Vector3 moveDirection)
    {
      Vector3 liquidMovingDelta = moveDirection * (_pistonSpeed * _liquidSpeed * Time.deltaTime);
      if ((_liquidTransform.localScale + liquidMovingDelta).y >= _minLiquidScale)
        _liquidTransform.localScale += liquidMovingDelta;
      else
        _liquidTransform.localScale = new Vector3(liquidScale.x, _minLiquidScale, liquidScale.z);
    }

    private IEnumerator Reset()
    {
      _audioSource.PlayOneShot(_audioClipReset);
      _pistonTransform.localPosition = _minPistonPosition;
      _liquidTransform.localScale = new Vector3(1, _minLiquidScale, 1);

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

    private IEnumerator MoveBack()
    {
      _isMovingBack = true;
      for (float currentTime = 0; currentTime < _movingBackTime; currentTime += Time.deltaTime)
      {
        transform.position = Vector3.Lerp(transform.position, _injectionStartPosition, currentTime / _movingBackTime);
        yield return null;
      }

      _isMovingBack = false;
    }
  }
}