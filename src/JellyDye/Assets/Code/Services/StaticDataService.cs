using Code.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Services
{
  public class StaticDataService : IInitializable
  {
    private const string SkinsDataPath = "StaticData/Skins";
    
    private SkinsStaticData _skinsStaticData;

    public void Initialize()
    {
      _skinsStaticData = Resources.Load<SkinsStaticData>(SkinsDataPath);
    }

    public SkinsStaticData ForSkins() => _skinsStaticData;
  }
}