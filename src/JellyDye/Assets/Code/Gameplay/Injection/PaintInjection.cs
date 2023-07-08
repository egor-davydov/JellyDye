using System.Collections;
using Fluxy;
using UnityEngine;

namespace Code.Gameplay.Injection
{
  public class PaintInjection : MonoBehaviour
  {
    [SerializeField] private FluxyTarget _fluxyTarget;
    [SerializeField] private MeshRenderer _liquidRenderer;
    [SerializeField] private float _paintIncreaseOverTime;
    [SerializeField] private Transform _pistonTransform;
    [SerializeField] private Transform _liquidTransform;
    [SerializeField] private float _pistonSpeed;
    [SerializeField] private float _liquidSpeed;
    [SerializeField] private float _movingCloserTime;
    [SerializeField] private float _movingBackTime;
    [SerializeField] private Vector3 _movingCloserVector;
    [SerializeField, Range(0, 2)] private float _movingCloserDistance = 1;
    [SerializeField, Range(0, 1)] private float _movingLittleBackDistance = 0.3f;
    [SerializeField] private float _movingLittleBackTime;
    [SerializeField] private float _resetTime;

    private const KeyCode InjectionKeyCode = KeyCode.Q;
    private static readonly int LiquidColorId = Shader.PropertyToID("_Color");

    private Vector3 _injectionStartPosition;
    private Coroutine _injectionCoroutine;
    private bool _isMovingBack;
    private float _liquidRegardingSpeed;
    private SphereCollider _paintCollider;

    private void Start()
    {
      _paintCollider = _fluxyTarget.GetComponent<SphereCollider>();
      _liquidRenderer.sharedMaterial = new Material(_liquidRenderer.sharedMaterial.shader);
      _liquidRenderer.sharedMaterial.SetColor(LiquidColorId, new Color(1, 0, 0));
      _liquidRegardingSpeed = _pistonSpeed * _liquidSpeed;
    }

    private void Update()
    {
      if (_isMovingBack)
        return;

      if (Input.GetKeyDown(InjectionKeyCode))
      {
        _injectionStartPosition = transform.position;
        _injectionCoroutine = StartCoroutine(Injection());
      }

      if (Input.GetKeyUp(InjectionKeyCode))
      {
        StopCoroutine(_injectionCoroutine);
        StopPaint();
        StartCoroutine(MoveBack());
      }
    }

    private IEnumerator Injection()
    {
      for (float currentTime = 0; currentTime < _movingCloserTime; currentTime += Time.deltaTime)
      {
        transform.position = Vector3.Lerp(transform.position, transform.position - _movingCloserVector * _movingCloserDistance, currentTime / _movingCloserTime);
        yield return null;
      }

      for (float currentTime = 0; currentTime < _movingLittleBackTime; currentTime += Time.deltaTime)
      {
        transform.position = Vector3.Lerp(transform.position, transform.position + _movingCloserVector * _movingLittleBackDistance, currentTime / _movingLittleBackTime);
        yield return null;
      }

      while (Input.GetKey(InjectionKeyCode))
      {
        if (_liquidTransform.localScale.y <= 0)
        {
          StopPaint();
          yield break;
        }

        StartPaint();
        _paintCollider.radius += _paintIncreaseOverTime * Time.deltaTime;
        _pistonTransform.localPosition += Vector3.down * (_pistonSpeed * Time.deltaTime);
        _liquidTransform.localScale += Vector3.down * (_liquidRegardingSpeed * Time.deltaTime);
        yield return null;
      }
    }

    private void StopPaint()
    {
      _paintCollider.radius = 0;
      _fluxyTarget.enabled = false;
    }

    private void StartPaint()
    {
      _paintCollider.radius = 0.3f;
      _fluxyTarget.enabled = true;
    }

    private IEnumerator Reset()
    {
      for (float currentTime = 0; currentTime < _resetTime; currentTime += Time.deltaTime)
      {
        transform.position = Vector3.Lerp(transform.position, transform.position + _movingCloserVector * _movingLittleBackDistance, currentTime / _resetTime);
        yield return null;
      }
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