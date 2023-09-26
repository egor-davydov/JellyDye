using System.Collections.Generic;
using Code.Data;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Services.Progress
{
  public class ProgressService
  {
    public PlayerProgress Progress { get; private set; }

    public void SetProgress(PlayerProgress progress)
    {
      Progress = progress;
    }
    
    public void CreateProgress()
    {
      Progress = new PlayerProgress();
    }
  }
}