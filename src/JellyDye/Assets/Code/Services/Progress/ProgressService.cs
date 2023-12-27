using System.Collections.Generic;
using Code.Data;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Services.Progress
{
  public class ProgressService
  {
    private readonly StaticDataService _staticDataService;
    public PlayerProgress Progress { get; private set; }

    public ProgressService(StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
    }
    public void SetProgress(PlayerProgress progress)
    {
      Progress = progress;
    }
    
    public void CreateAndSetNewProgress()
    {
      Progress = NewProgress();
    }

    public PlayerProgress NewProgress()
    {
      return new PlayerProgress(_staticDataService.ForLevels().LevelConfigs[0].Id);
    }
  }
}