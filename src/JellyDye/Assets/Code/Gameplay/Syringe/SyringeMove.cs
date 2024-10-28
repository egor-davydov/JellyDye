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

    private InputService _inputService;

    [Inject]
    public void Construct(InputService inputService)
    {
      _inputService = inputService;
    }

    private void Start() =>
      _camera = Camera.main;

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