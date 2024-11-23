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

    public GameSettings ForGameSettings { get; private set; }
    public CcdTokensStaticData ForCcdTokens { get; private set; }
    public SkinsStaticData ForSkins { get; private set; }
    public LevelsStaticData ForLevels { get; private set; }

    public void Initialize()
    {
      ForSkins = Resources.Load<SkinsStaticData>(SkinsDataPath);
      ForLevels = Resources.Load<LevelsStaticData>(LevelsDataPath);
      ForCcdTokens = Resources.Load<CcdTokensStaticData>(TokensDataPath);
      ForGameSettings = Resources.Load<GameSettings>(GameSettingsPath);

      _skinsStaticData = ForSkins.SkinConfigs.ToDictionary(x => x.SkinType);
      _levelsStaticData = ForLevels.LevelConfigs.ToDictionary(x => x.Id);
      _tokensStaticData = ForCcdTokens.Configs.ToDictionary(x => x.ProfileName);
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