using Code.Data;

namespace Code.Services.Progress.SaveLoad
{
  public interface ISaveLoadService
  {
    void SaveProgress();
    PlayerProgress LoadProgress();
    bool IsPlayerHaveProgress();
  }
}