using Code.StaticData;
using Code.StaticData.Level;
using Code.StaticData.Skins;
using UnityEngine;
using Zenject;

namespace Code.Services
{
  public class StaticDataService : IInitializable
  {
    private const string SkinsDataPath = "StaticData/Skins";
    private const string LevelsDataPath = "StaticData/Levels";
    private const string JelliesDataPath = "StaticData/Jellies";
    
    private SkinsStaticData _skinsStaticData;
    private LevelsStaticData _levelsStaticData;
    private JelliesStaticData _jelliesStaticData;

    public void Initialize()
    {
      _skinsStaticData = Resources.Load<SkinsStaticData>(SkinsDataPath);
      _levelsStaticData = Resources.Load<LevelsStaticData>(LevelsDataPath);
      _jelliesStaticData = Resources.Load<JelliesStaticData>(JelliesDataPath);
    }

    public SkinsStaticData ForSkins() => _skinsStaticData;
    public LevelsStaticData ForLevels() => _levelsStaticData;
    public JelliesStaticData ForJellies() => _jelliesStaticData;
  }
}