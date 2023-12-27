using System;
using Code.Gameplay.UI.MainMenu.Skins;
using UnityEngine;

namespace Code.StaticData.Skins
{
  [Serializable]
  public class UnlockableSkinConfig
  {
    [field: SerializeField] public SkinType SkinType { get; private set; }
    [field: SerializeField] public Sprite Icon { get; private set; }
  }
}