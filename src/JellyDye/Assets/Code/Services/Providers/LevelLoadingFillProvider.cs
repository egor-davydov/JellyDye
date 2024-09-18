using Code.Gameplay.Logic.UI;

namespace Code.Services.Providers
{
  public class LevelLoadingFillProvider
  {
    public LevelLoadingFill LevelLoadingFill { get; private set; }
    
    public void Initialize(LevelLoadingFill levelLoadingFill)
    {
      LevelLoadingFill = levelLoadingFill;
    }
  }
}