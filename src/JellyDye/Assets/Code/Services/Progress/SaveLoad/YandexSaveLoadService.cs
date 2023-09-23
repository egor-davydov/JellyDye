using System.Runtime.InteropServices;
using Code.Data;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class YandexSaveLoadService : ISaveLoadService
  {
    private readonly ProgressService _progressService;

    [DllImport("__Internal")] private static extern void SaveToYandex(string json);
    [DllImport("__Internal")] private static extern string LoadFromYandex();

    public YandexSaveLoadService(ProgressService progressService)
    {
      _progressService = progressService;
    }

    public void SaveProgress()
    {
      string json = JsonUtility.ToJson(_progressService.Progress);
      SaveToYandex(json);
    }

    public PlayerProgress LoadProgress()
    {
      string json = LoadFromYandex();
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(json);

      return playerProgress;
    }

    public bool IsPlayerHaveProgress()
    {
      string json = LoadFromYandex();

      return json != "";
    }
  }
}