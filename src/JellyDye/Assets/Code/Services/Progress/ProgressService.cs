using Code.Data;

namespace Code.Services.Progress
{
  public class ProgressService
  {
    public PlayerProgress Progress { get; private set; }

    public void CreateProgress()
    {
      Progress = new PlayerProgress();
    }
  }
}