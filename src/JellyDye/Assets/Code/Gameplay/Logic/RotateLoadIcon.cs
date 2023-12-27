using System.Collections;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class RotateLoadIcon : MonoBehaviour
  {
    [SerializeField] private float _rotationSpeed;
    
    private void Awake()
    {
      StartCoroutine(RotationRoutine());
    }

    private IEnumerator RotationRoutine()
    {
      while (true)
      {
        transform.eulerAngles += Vector3.forward * _rotationSpeed;
        yield return null;
      }
    }
  }
}