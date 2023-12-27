using System;

namespace Code.Services.Progress.SaveLoad
{
  public interface ISaveLoadService
  {
    void SaveProgress();
    void LoadProgress(Action onLoaded = null);
  }
}