using UnityEngine;

namespace Code.StaticData
{
  [CreateAssetMenu(fileName = "DevelopHelpers", menuName = "StaticData/DevelopHelpers", order = 0)]
  public class DevelopHelpersStaticData : ScriptableObject
  {
    [field: SerializeField] public bool FinishLevelImmediately { get; private set; }
    [field: SerializeField] public bool OpenNewSkin { get; private set; }
    [field: SerializeField] public bool IsShowingNames { get; private set; }
  }
}