using System.Collections.Generic;
using UnityEngine;

namespace Code.StaticData
{
  
  [CreateAssetMenu(menuName = "StaticData/Skins", fileName = "Skins", order = 0)]
  public class SkinsStaticData : ScriptableObject
  {
    public SkinConfig[] SkinConfigs;
  }
}