using Code.Gameplay.UI.MainMenu.Skins;
using UnityEngine;

namespace Code.StaticData.Skins
{
  
  [CreateAssetMenu(menuName = "StaticData/Skins", fileName = "Skins", order = 0)]
  public class SkinsStaticData : ScriptableObject
  {
    public UnlockableSkinConfig[] UnlockableSkins;
    public SkinConfig[] SkinConfigs;
  }
}