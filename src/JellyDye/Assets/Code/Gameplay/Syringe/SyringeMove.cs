using Code.Services;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Code.Gameplay.Syringe
{
  public class SyringeMove : MonoBehaviour
  {
    [SerializeField] private Vector2 _positionBoundsX;
    [SerializeField] private Vector2 _positionBoundsZ;
    
    private bool _isDragging;
    private Camera _camera;
    private Vector3 _delta;
    private Vector3 _worldToScreenPoint;
    
    private PublishService _publishService;

    [Inject]
    public void Construct(PublishService publishService)
    {
      _publishService = publishService;
    }
    
    private void Start() =>
      _camera = Camera.main;

    private void Update()
    {
      if (Input.GetMouseButtonDown(0) && !IsPointerOverUIObject())
      {
        _delta = transform.position - GetMouseWorldPosition();
        _isDragging = true;
      }

      if (_isDragging)
      {
        Vector3 newPosition = CalculateNewPosition();
        transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);
      }

      if (Input.GetMouseButtonUp(0))
      {
        _isDragging = false;
      }
    }

    private Vector3 CalculateNewPosition()
    {
      Vector3 newPosition = GetMouseWorldPosition() + _delta;
      newPosition.x = Mathf.Clamp(newPosition.x, _positionBoundsX.x, _positionBoundsX.y);
      newPosition.z = Mathf.Clamp(newPosition.z, _positionBoundsZ.x, _positionBoundsZ.y);
      return newPosition;
    }

    private bool IsPointerOverUIObject()
    {
      if (!_publishService.IsPlatformMobile())
        return EventSystem.current.IsPointerOverGameObject();
      
      for (int i = 0; i < Input.touchCount; i++)
      {
        var touch = Input.GetTouch(i);
        if (touch.phase != TouchPhase.Began)
          continue;
        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
          return true;
      }
      return false;
    }

    private Vector3 GetMouseWorldPosition()
    {
      Vector3 mousePosition = Input.mousePosition;
      mousePosition.z = _camera.transform.position.y;
      return _camera.ScreenToWorldPoint(mousePosition);
    }
  }
}