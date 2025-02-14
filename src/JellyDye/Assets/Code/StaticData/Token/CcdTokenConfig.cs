using System;

namespace Code.StaticData.Token
{
  [Serializable]
  public class CcdTokenConfig
  {
    public string ProfileName;
    public string Token;

    public CcdTokenConfig(string profileName)
    {
      ProfileName = profileName;
    }
  }
}