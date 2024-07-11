using System;
using Code.Gameplay.UI.MainMenu.Skins;
using UnityEngine.AddressableAssets;

namespace Code.StaticData.Skins
{
  [Serializable]
  public class SkinConfig
  {
    public SkinType SkinType;
    public AssetReference SkinReference;
  }
}