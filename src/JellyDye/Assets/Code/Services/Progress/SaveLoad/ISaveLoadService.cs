using System;

namespace Code.Services.Progress.SaveLoad
{
  public interface ISaveLoadService
  {
    void SaveProgress();
    void LoadProgressAsync(Action onLoaded = null);
  }
}