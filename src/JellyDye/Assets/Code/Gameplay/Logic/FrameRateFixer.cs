using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class FrameRateFixer : MonoBehaviour
  {
    [SerializeField, Range(-1, 120)] private int _targetFpsCount;
    
    private void Awake() => 
      Application.targetFrameRate = _targetFpsCount;
  }
}