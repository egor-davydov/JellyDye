using System;
using System.Linq;
using Code.Data;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Services.Progress
{
  public class ProgressService
  {
    private readonly StaticDataService _staticDataService;

    public ProgressService(StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
    }

    public PlayerProgress Progress { get; private set; }

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
      return new PlayerProgress(_staticDataService.Levels.LevelConfigs.First().Id, Enum.GetValues(typeof(SkinType)).Length);
    }
  }
}