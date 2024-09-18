using System;

namespace Code.StaticData.Token
{
  [Serializable]
  public class CCDTokenConfig
  {
    public string ProfileName;
    public string Token;

    public CCDTokenConfig(string profileName)
    {
      ProfileName = profileName;
    }
  }
}