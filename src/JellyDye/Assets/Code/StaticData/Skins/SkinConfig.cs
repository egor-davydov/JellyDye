using System;
using Code.Enums;
using UnityEngine.AddressableAssets;

namespace Code.StaticData.Skins
{
  [Serializable]
  public class SkinConfig
  {
    public SkinType SkinType;
    public AssetReference SkinReference;
    public string RuName;
  }
}