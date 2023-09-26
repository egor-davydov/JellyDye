using System;
using System.Runtime.InteropServices;
using AOT;
using Code.Data;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class YandexSaveLoadService : ISaveLoadService
  {
    private static ProgressService _progressService;
    
    private static Action _onLoaded;

    [DllImport("__Internal")] private static extern void SaveToYandex(string json);
    [DllImport("__Internal")] private static extern void LoadFromYandex(Action<string> onLoaded);

    public YandexSaveLoadService(ProgressService progressService)
    {
      _progressService = progressService;
    }

    public void SaveProgress()
    {
      string json = JsonUtility.ToJson(_progressService.Progress);
      SaveToYandex(json);
    }

    public void LoadProgressAsync(Action onLoaded = null)
    {
      _onLoaded = onLoaded;
      LoadFromYandex(onLoaded: SetPlayerProgress);
    }

    [MonoPInvokeCallback(typeof(Action<string>))]
    private static void SetPlayerProgress(string jsonCloudData)
    {
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(jsonCloudData);
      _progressService.SetProgress(playerProgress);
      _onLoaded?.Invoke();
    }
  }
}