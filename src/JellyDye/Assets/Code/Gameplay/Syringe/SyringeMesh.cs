using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringeMesh : MonoBehaviour
  {
    [field: SerializeField] public Transform PistonTransform { get; private set; }
    [field: SerializeField] public Transform LiquidTransform { get; private set; }
    [field: SerializeField] public MeshRenderer LiquidRenderer { get; private set; }
  }
}