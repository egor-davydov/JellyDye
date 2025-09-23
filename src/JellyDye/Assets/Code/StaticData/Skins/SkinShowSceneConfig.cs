using System;
using UnityEngine;

namespace Code.StaticData.Skins
{
  [Serializable]
  public struct SkinShowSceneConfig
  {
    [field: SerializeField] public float AutoRotationSpeed { get; private set; }
    [field: SerializeField] public float RotationSpeed { get; private set; }
    [field: SerializeField] public float InertiaDamping { get; private set; }
    [field: SerializeField] public float DelayBeforeCloseButtonCreation { get; private set; }
    [field: SerializeField] public AudioClip NewSkinSound { get; private set; }
  }
}