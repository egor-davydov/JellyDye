using UnityEngine;

namespace Code.Gameplay.Logic.UI
{
  public class RotateLoadIcon : MonoBehaviour
  {
    [SerializeField] private float _rotationSpeed;
    
    private void Update()
    {
      transform.eulerAngles += Vector3.forward * (_rotationSpeed * Time.deltaTime);
    }
  }
}