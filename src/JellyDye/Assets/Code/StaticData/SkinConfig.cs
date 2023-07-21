using System;
using Code.Gameplay.UI.MainMenu.Skins;
using UnityEngine;

namespace Code.StaticData
{
  [Serializable]
  public class SkinConfig
  {
    public SkinType SkinType;
    public GameObject SkinPrefab;
  }
}