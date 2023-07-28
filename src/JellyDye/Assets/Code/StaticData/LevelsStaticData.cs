using UnityEngine;

namespace Code.StaticData
{
  [CreateAssetMenu(menuName = "StaticData/Levels", fileName = "Levels", order = 0)]
  public class LevelsStaticData : ScriptableObject
  {
    public LevelConfig[] LevelConfigs;

  }
}