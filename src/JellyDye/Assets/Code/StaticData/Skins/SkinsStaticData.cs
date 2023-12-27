using UnityEngine;

namespace Code.StaticData.Skins
{
  
  [CreateAssetMenu(menuName = "StaticData/Skins", fileName = "Skins", order = 0)]
  public class SkinsStaticData : ScriptableObject
  {
    public UnlockableSkinConfig[] UnlockableSkins;
    public SkinConfig[] SkinConfigs;
    [field: SerializeField, Range(0, 1)] public float MinSkinProgress { get; private set; }
  }
}