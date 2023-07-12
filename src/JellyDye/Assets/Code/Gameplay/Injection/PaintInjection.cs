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
    private const float MinLiquidScale = 0.05f;
    private static readonly Vector3 MinPistonPosition = new Vector3(0, 0.326f, 0);
    private static readonly int LiquidColorId = Shader.PropertyToID("_Color");

    private Vector3 _injectionStartPosition;
    private Coroutine _injectionCoroutine;
    private bool _isMovingBack;
    private Vector3 _pistonResetPosition;
    private float _liquidResetScale;

    private void Awake()
    {
      _liquidRenderer.sharedMaterial = new Material(_liquidRenderer.sharedMaterial.shader);
      _pistonResetPosition = _pistonTransform.localPosition;
      _liquidResetScale = _liquidTransform.localScale.y;
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

    public void ChangeLiquidColor(Color newColor) => 
      _liquidRenderer.sharedMaterial.SetColor(LiquidColorId, newColor);

    public void SyringeReset() => 
      StartCoroutine(Reset());

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

      if (_liquidTransform.localScale.y > MinLiquidScale)
        StartPaint();
      while (Input.GetKey(InjectionKeyCode))
      {
        if (_liquidTransform.localScale.y == MinLiquidScale)
        {
          StopPaint();
          SyringeReset();
          yield break;
        }

        _fluxyTarget.scale += Vector2.one * (_paintIncreaseOverTime * Time.deltaTime);
        _pistonTransform.localPosition += Vector3.down * (_pistonSpeed * Time.deltaTime);
        MoveLiquid(_liquidTransform.localScale, Vector3.down);
        yield return null;
      }
    }

    private void StartPaint()
    {
      _fluxyTarget.enabled = true;
    }

    private void StopPaint()
    {
      _fluxyTarget.scale = Vector2.zero;
      _fluxyTarget.enabled = false;
    }

    private void MoveLiquid(Vector3 liquidScale, Vector3 moveDirection)
    {
      Vector3 liquidMovingDelta = moveDirection * (_pistonSpeed * _liquidSpeed * Time.deltaTime);
      if ((_liquidTransform.localScale + liquidMovingDelta).y >= MinLiquidScale)
        _liquidTransform.localScale += liquidMovingDelta;
      else
        _liquidTransform.localScale = new Vector3(liquidScale.x, MinLiquidScale, liquidScale.z);
    }

    private IEnumerator Reset()
    {
      _pistonTransform.localPosition = MinPistonPosition;
      _liquidTransform.localScale = new Vector3(1, MinLiquidScale, 1);

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