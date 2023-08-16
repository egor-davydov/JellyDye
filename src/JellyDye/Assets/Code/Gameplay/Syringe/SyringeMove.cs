using UnityEngine;
using UnityEngine.EventSystems;

namespace Code.Gameplay.Syringe
{
  public class SyringeMove : MonoBehaviour
  {
    //[SerializeField, Range(0, 0.05f)] private float _moveSpeed = 0.05f;

    private bool _isDragging;
    private Vector3 _offset;
    private Camera _camera;
    private Vector3 _delta;
    private Vector3 _worldToScreenPoint;

    private void Start() =>
      _camera = Camera.main;

    private void Update()
    {
      // Vector3 prev = _worldToScreenPoint;
      // _worldToScreenPoint = _camera.WorldToScreenPoint(GetMouseWorldPosition());
      // if(_worldToScreenPoint != prev)
      // Debug.Log(_worldToScreenPoint);
      if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
      {
        _delta = transform.position - GetMouseWorldPosition();
        _isDragging = true;
      }

      if (_isDragging)
      {
        Vector3 newPosition = GetMouseWorldPosition() + _delta;
        transform.position = new Vector3(newPosition.x + _offset.x, transform.position.y, newPosition.z + _offset.z);
      }

      if (Input.GetMouseButtonUp(0))
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