using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.UI.MainMenu.Skins;
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
    private const string GameSettingsPath = "StaticData/GameSettings";

    private Dictionary<SkinType, SkinConfig> _skinsStaticData;
    private Dictionary<string, LevelConfig> _levelsStaticData;
    private Dictionary<string, CcdTokenConfig> _tokensStaticData;

    public GameSettings GameSettings { get; private set; }
    public CcdTokensStaticData CcdTokens { get; private set; }
    public SkinsStaticData Skins { get; private set; }
    public LevelsStaticData Levels { get; private set; }

    public void Initialize()
    {
      Skins = Resources.Load<SkinsStaticData>(SkinsDataPath);
      Levels = Resources.Load<LevelsStaticData>(LevelsDataPath);
      CcdTokens = Resources.Load<CcdTokensStaticData>(TokensDataPath);
      GameSettings = Resources.Load<GameSettings>(GameSettingsPath);

      _skinsStaticData = Skins.SkinConfigs.ToDictionary(x => x.SkinType);
      _levelsStaticData = Levels.LevelConfigs.ToDictionary(x => x.Id);
      _tokensStaticData = CcdTokens.Configs.ToDictionary(x => x.ProfileName);
    }

    public SkinConfig ForSkin(SkinType skinType) => _skinsStaticData[skinType];

    public CcdTokenConfig ForCcdToken(string profileName)
    {
      return _tokensStaticData.TryGetValue(profileName, out CcdTokenConfig token)
        ? token
        : null;
    }

    public LevelConfig ForLevel(string levelId) => _levelsStaticData[levelId];
  }
}