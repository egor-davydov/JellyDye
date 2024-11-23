using Code.Services;
using Code.StaticData.Skins;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringeRotation : MonoBehaviour
  {
    private InputService _inputService;
    private StaticDataService _staticDataService;

    private Vector3? _skinRotationPoint;

    private Vector3 _previousMousePosition;
    private Vector2 _currentRotationVelocity;
    private Vector2 _lastRotationVelocity;
    private bool _isUserRotateSkin;

    private bool _isSkinAutoRotating = true;

    public void Construct(InputService inputService, StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
      _inputService = inputService;
    }

    public void Initialize(Vector3 skinRotationPoint)
    {
      _skinRotationPoint = skinRotationPoint;
    }

    private NewSkinSceneConfig NewSkinSceneConfig => _staticDataService.Skins.NewSkinSceneConfig;

    private void Update()
    {
      if (_skinRotationPoint == null)
        return;
      if (_isSkinAutoRotating)
      {
        transform.RotateAround(_skinRotationPoint.Value, Vector3.up,
          -NewSkinSceneConfig.AutoRotationSpeed * Time.deltaTime);
      }

      if (_inputService.IsInputButtonPressedInGameSpace)
      {
        _isSkinAutoRotating = false;
        _isUserRotateSkin = true;
        _previousMousePosition = Input.mousePosition;
      }

      if (_isUserRotateSkin && _inputService.IsInputButtonReleased)
      {
        _isUserRotateSkin = false;
        _lastRotationVelocity = _currentRotationVelocity;
      }

      if (_isUserRotateSkin)
      {
        Vector3 mouseDelta = Input.mousePosition - _previousMousePosition;

        float rotationY = -mouseDelta.x * NewSkinSceneConfig.RotationSpeed * Time.deltaTime;
        float rotationX = mouseDelta.y * NewSkinSceneConfig.RotationSpeed * Time.deltaTime;

        _currentRotationVelocity = new Vector2(rotationX, rotationY);

        RotateWithVelocity(transform, _currentRotationVelocity);

        _previousMousePosition = Input.mousePosition;
      }
      else if (_lastRotationVelocity != Vector2.zero)
      {
        float dampingFactor = 1f - (NewSkinSceneConfig.InertiaDamping * Time.deltaTime);
        _lastRotationVelocity *= dampingFactor;

        if (_lastRotationVelocity.sqrMagnitude < 0.01f)
          _lastRotationVelocity = Vector2.zero;

        RotateWithVelocity(transform, _lastRotationVelocity);
      }
    }

    private void RotateWithVelocity(Transform rotationTransform, Vector2 rotationVelocity)
    {
      rotationTransform.RotateAround(_skinRotationPoint.Value, Vector3.up, rotationVelocity.y);
      rotationTransform.RotateAround(_skinRotationPoint.Value, Vector3.right, rotationVelocity.x);
    }
  }
}