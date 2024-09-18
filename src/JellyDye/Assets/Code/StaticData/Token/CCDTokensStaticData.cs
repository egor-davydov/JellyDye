using System.Collections.Generic;
using UnityEngine;

namespace Code.StaticData.Token
{
  [CreateAssetMenu(menuName = "StaticData/CCDTokens", fileName = "CCDTokens", order = 0)]
  public class CCDTokensStaticData : ScriptableObject
  {
    public string ActiveProfileName;
    public List<CCDTokenConfig> Configs;
  }
}