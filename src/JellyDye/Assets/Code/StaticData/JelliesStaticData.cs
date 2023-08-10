using UnityEngine;

namespace Code.StaticData
{
  [CreateAssetMenu(menuName = "StaticData/Jellies", fileName = "Jellies", order = 0)]
  public class JelliesStaticData : ScriptableObject
  {
    public JellyConfig[] JellyConfigs;
  }
}