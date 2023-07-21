using System;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public SkinData SkinData;

    public PlayerProgress()
    {
      SkinData = new SkinData();
    }
  }
}