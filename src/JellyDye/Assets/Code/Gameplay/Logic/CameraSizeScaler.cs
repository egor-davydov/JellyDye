using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class CameraSizeScaler : MonoBehaviour
  {
    [SerializeField] private Camera _camera;
    [SerializeField] private float _scaleIfLessThen = 1.76f;
    [SerializeField] private float _scaleTo = 1.28f;

    private void Awake()
    {
      if ((float)Screen.height / Screen.width < _scaleIfLessThen)
        _camera.orthographicSize = _scaleTo;
    }
  }
}