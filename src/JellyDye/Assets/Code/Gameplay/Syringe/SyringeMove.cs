using UnityEngine;
using UnityEngine.EventSystems;

namespace Code.Gameplay.Syringe
{
  public class SyringeMove : MonoBehaviour
  {
    //[SerializeField, Range(0, 0.05f)] private float _moveSpeed = 0.05f;

    private bool isDragging;
    private Vector3 offset;
    private Camera _camera;
    private Vector3 _delta;

    private void Start() =>
      _camera = Camera.main;

    private void Update()
    {
      if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
      {
        _delta = transform.position - GetMouseWorldPosition();
        isDragging = true;
        Debug.Log("StartDrag");
      }

      if (isDragging)
      {
        Vector3 newPosition = GetMouseWorldPosition() + _delta;
        transform.position = new Vector3(newPosition.x + offset.x, transform.position.y, newPosition.z + offset.z);
        Debug.Log("Dragged");
      }

      if (Input.GetMouseButtonUp(0))
      {
        Debug.Log("StopDrag");
        isDragging = false;
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