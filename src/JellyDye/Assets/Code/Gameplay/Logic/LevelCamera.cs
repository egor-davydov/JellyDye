using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class LevelCamera : MonoBehaviour
  {
    [SerializeField] private Camera _camera;
    [SerializeField] private Vector3 _finishPosition;
    [SerializeField] private Vector3 _finishRotation;
    [SerializeField] private float _movingTime;
    [SerializeField] private float _targetSize;

    public float TargetSize => _targetSize;
    public Camera Camera => _camera;
    public float MovingTime => _movingTime;
    public Vector3 FinishPosition => _finishPosition;
    public Vector3 FinishRotation => _finishRotation;
  }
}