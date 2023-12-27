using System;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class CameraSizeScaler : MonoBehaviour
  {
    [SerializeField] private Camera _camera;
    [SerializeField] private float _boundsSizeX = 1.3f;
    [SerializeField] private float _boundsSizeY = 2.8f;

    private void Awake()
    {
      ChangeCameraSize();
      //_button.onClick.AddListener(ChangeCameraSize);
    }

    private void ChangeCameraSize()
    {
      float screenRatio = Screen.width / (float)Screen.height;
      float targetRatio = _boundsSizeX / _boundsSizeY;

      if(screenRatio >= targetRatio){
        _camera.orthographicSize = _boundsSizeY / 2;
      }else{
        float differenceInSize = targetRatio / screenRatio;
        _camera.orthographicSize = _boundsSizeY / 2 * differenceInSize;
      }
      // Debug.Log($"screenRatio={screenRatio}");
      // Debug.Log($"targetRatio={targetRatio}");
      // Debug.Log($"_camera.orthographicSize={_camera.orthographicSize}");
    }
  }
}