using Code.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Services
{
  public class StaticDataService : IInitializable
  {
    private const string SkinsDataPath = "StaticData/Skins";
    private const string LevelsDataPath = "StaticData/Levels";
    
    private SkinsStaticData _skinsStaticData;
    private LevelsStaticData _levelsStaticData;

    public void Initialize()
    {
      _skinsStaticData = Resources.Load<SkinsStaticData>(SkinsDataPath);
      _levelsStaticData = Resources.Load<LevelsStaticData>(LevelsDataPath);
    }

    public SkinsStaticData ForSkins() => _skinsStaticData;
    public LevelsStaticData ForLevels() => _levelsStaticData;
  }
}