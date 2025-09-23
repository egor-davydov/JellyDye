using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.StaticData.Skins
{
  [CreateAssetMenu(menuName = "StaticData/Skins", fileName = "Skins", order = 0)]
  public class SkinsStaticData : ScriptableObject
  {
    [field: SerializeField] public AssetReference SyringeBaseReference { get; private set; }
    public UnlockableSkinConfig[] UnlockableSkins;
    public SkinConfig[] SkinConfigs;
    [field: SerializeField, Range(0, 1)] public float MinSkinProgress { get; private set; }
    [field: SerializeField] public SkinShowSceneConfig SkinShowSceneConfig { get; private set; }
  }
}