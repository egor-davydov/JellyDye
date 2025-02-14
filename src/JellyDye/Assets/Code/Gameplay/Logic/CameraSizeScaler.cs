using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class CameraSizeScaler : MonoBehaviour
  {
    [SerializeField] private Camera _camera;
    [SerializeField] private float _boundsSizeX = 1.3f;
    [SerializeField] private float _boundsSizeY = 2.4f;

    private void Awake()
    {
      _camera.orthographicSize = GetOrthoSize(_boundsSizeX, _boundsSizeY);
    }

    private float GetOrthoSize(float boundsSizeX, float boundsSizeY)
    {
      float screenRatio = Screen.width / (float)Screen.height;
      float targetRatio = boundsSizeX / boundsSizeY;

      if (screenRatio >= targetRatio)
        return boundsSizeY / 2;

      float differenceInSize = targetRatio / screenRatio;
      return boundsSizeY / 2 * differenceInSize;
    }
  }
}