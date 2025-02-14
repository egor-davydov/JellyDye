using Code.Enums;
using UnityEngine;

namespace Code.StaticData
{
  [CreateAssetMenu(menuName = "StaticData/GameSettings", fileName = "GameSettings", order = 0)]
  public class GameSettings : ScriptableObject
  {
    public LanguageType DefaultLanguage;
  }
}