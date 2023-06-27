using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringeMove : MonoBehaviour
  {
    [SerializeField, Range(0, 0.05f)] private float _moveSpeed = 0.01f;
    
    private Vector3 _previousMousePosition;

    private void Update()
    {
      if (Input.GetMouseButton(0))
      {
        Vector3 moveDelta = Input.mousePosition - _previousMousePosition;
        transform.position += new Vector3(moveDelta.x, 0, moveDelta.y) * _moveSpeed;
      }
      _previousMousePosition = Input.mousePosition;
    }
  }
}