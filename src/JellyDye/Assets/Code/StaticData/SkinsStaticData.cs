using System.Collections.Generic;
using UnityEngine;

namespace Code.StaticData
{
  
  [CreateAssetMenu(menuName = "Create SkinsStaticData", fileName = "SkinsStaticData", order = 0)]
  public class SkinsStaticData : ScriptableObject
  {
    public List<SkinConfig> SkinConfigs;
  }
}