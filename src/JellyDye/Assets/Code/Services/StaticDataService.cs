using Code.StaticData;
using Code.StaticData.Level;
using Code.StaticData.Skins;
using Code.StaticData.Token;
using UnityEngine;

namespace Code.Services
{
  public class StaticDataService
  {
    private const string SkinsDataPath = "StaticData/Skins";
    private const string LevelsDataPath = "StaticData/Levels";
    private const string TokensDataPath = "StaticData/CCDTokens";
    
    private SkinsStaticData _skinsStaticData;
    private LevelsStaticData _levelsStaticData;
    private CCDTokensStaticData _tokensStaticData;

    public void LoadData()
    {
      _skinsStaticData = Resources.Load<SkinsStaticData>(SkinsDataPath);
      _levelsStaticData = Resources.Load<LevelsStaticData>(LevelsDataPath);
      _tokensStaticData = Resources.Load<CCDTokensStaticData>(TokensDataPath);
    }

    public CCDTokensStaticData ForCCDTokens() => _tokensStaticData;
    public SkinsStaticData ForSkins() => _skinsStaticData;
    public LevelsStaticData ForLevels() => _levelsStaticData;
  }
}