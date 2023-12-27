using Code.StaticData;
using Code.StaticData.Level;
using Code.StaticData.Skins;
using UnityEngine;

namespace Code.Services
{
  public class StaticDataService
  {
    private const string SkinsDataPath = "StaticData/Skins";
    private const string LevelsDataPath = "StaticData/Levels";
    
    private SkinsStaticData _skinsStaticData;
    private LevelsStaticData _levelsStaticData;

    public void LoadData()
    {
      _skinsStaticData = Resources.Load<SkinsStaticData>(SkinsDataPath);
      _levelsStaticData = Resources.Load<LevelsStaticData>(LevelsDataPath);
    }

    public SkinsStaticData ForSkins() => _skinsStaticData;
    public LevelsStaticData ForLevels() => _levelsStaticData;
  }
}