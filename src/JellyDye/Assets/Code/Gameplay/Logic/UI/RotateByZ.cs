using UnityEngine;

namespace Code.Gameplay.Logic.UI
{
  public class RotateByZ : MonoBehaviour
  {
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
      transform.eulerAngles += Vector3.forward * (_rotationSpeed * Time.deltaTime);
    }
  }
}