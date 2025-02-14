using System;
using System.Runtime.InteropServices;
using AOT;
using Code.Data;
using Code.Logging;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class YandexSaveLoadService : ISaveLoadService
  {
    private static ProgressService _progress;

    private static Action _onLoaded;

    [DllImport("__Internal")]
    private static extern void SaveToYandex(string json);

    [DllImport("__Internal")]
    private static extern void LoadFromYandex(Action<string> onLoaded);

    public YandexSaveLoadService(ProgressService progress)
    {
      _progress = progress;
    }

    public void SaveProgress()
    {
      string json = JsonUtility.ToJson(_progress.Whole);
      SaveToYandex(json);
    }

    public void LoadProgress(Action onLoaded = null)
    {
      _onLoaded = onLoaded;
      LoadFromYandex(onLoaded: SetPlayerProgress);
    }

    [MonoPInvokeCallback(typeof(Action<string>))]
    private static void SetPlayerProgress(string jsonCloudData)
    {
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(jsonCloudData);
      bool playerHaventProgress = playerProgress.LevelData.CurrentLevelId == default;
      WebDebug.Log(playerHaventProgress
        ? "Player haven't got any progress"
        : "Player has progress");
      if (playerHaventProgress)
        _progress.CreateAndSetStartProgress();
      else
        _progress.Whole = playerProgress;
      _onLoaded?.Invoke();
    }
  }
}