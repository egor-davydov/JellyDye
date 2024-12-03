using Code.Gameplay.UI.Hud;
using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Syringe
{
  public class SyringeMove : MonoBehaviour
  {
    [SerializeField] private Vector2 _positionBoundsX;
    [SerializeField] private Vector2 _positionBoundsZ;

    private bool _isDragging;
    private Camera _camera;
    private Vector3 _dragStartPoint;
    private Vector3 _worldToScreenPoint;
    private InjectionButton _injectionButton;

    private InputService _inputService;
    private CameraProvider _cameraProvider;

    [Inject]
    public void Construct(InputService inputService, CameraProvider cameraProvider)
    {
      _cameraProvider = cameraProvider;
      _inputService = inputService;
    }

    public void Initialize(InjectionButton injectionButton)
    {
      _injectionButton = injectionButton;
      _injectionButton.OnButtonDown += OnInjectionButtonDown;
      _injectionButton.OnButtonUp += OnInjectionButtonUp;
    }

    private void OnDestroy()
    {
      if (_injectionButton == null)
        return;
      _injectionButton.OnButtonDown -= OnInjectionButtonDown;
      _injectionButton.OnButtonUp -= OnInjectionButtonUp;
    }

    private void Awake()
    {
      _camera = _cameraProvider.LevelCamera.Camera;
    }

    private void OnInjectionButtonDown() =>
      enabled = false;

    private void OnInjectionButtonUp() =>
      enabled = true;

    private void Update()
    {
      if (_inputService.IsInputButtonPressedInGameSpace)
      {
        _dragStartPoint = transform.position - GetMouseWorldPosition();
        _isDragging = true;
      }

      if (_isDragging)
      {
        Vector3 newPosition = GetMouseWorldPosition() + _dragStartPoint;
        newPosition.x = Mathf.Clamp(newPosition.x, _positionBoundsX.x, _positionBoundsX.y);
        newPosition.z = Mathf.Clamp(newPosition.z, _positionBoundsZ.x, _positionBoundsZ.y);
        transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);
      }

      if (_inputService.IsInputButtonReleased)
      {
        _isDragging = false;
      }
    }

    private Vector3 GetMouseWorldPosition()
    {
      Vector3 mousePosition = Input.mousePosition;
      mousePosition.z = _camera.transform.position.y;
      return _camera.ScreenToWorldPoint(mousePosition);
    }
  }
}