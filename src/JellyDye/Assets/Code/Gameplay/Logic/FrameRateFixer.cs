using Unity.Burst;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class FrameRateFixer : MonoBehaviour
  {
    [SerializeField, Range(-1, 120)] private int _targetFpsCount;
    
    private void Awake()
    {
      BurstCompiler.Options.EnableBurstSafetyChecks = false;
      Application.targetFrameRate = _targetFpsCount;
    }
  }
}