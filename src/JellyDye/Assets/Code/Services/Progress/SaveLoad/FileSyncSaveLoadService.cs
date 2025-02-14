using System;
using System.IO;
using Code.Constants;
using Code.Data;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class FileSyncSaveLoadService : ISaveLoadService
  {
    private readonly ProgressService _progress;

    public FileSyncSaveLoadService(ProgressService progress)
    {
      _progress = progress;
    }

    public void SaveProgress()
    {
      using FileStream fileStream = File.Create(FilePath.ProgressPath);
      using StreamWriter streamWriter = new StreamWriter(fileStream);
      streamWriter.WriteLine(JsonUtility.ToJson(_progress.Whole));
    }

    public void LoadProgress(Action onLoaded = null)
    {
      if (PlayerHaveProgress() == false)
      {
        _progress.CreateAndSetStartProgress();
        onLoaded?.Invoke();
        return;
      }

      using FileStream fileStream = File.Open(FilePath.ProgressPath, FileMode.Open);
      using StreamReader streamReader = new StreamReader(fileStream);
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(streamReader.ReadToEnd());
      _progress.Whole = playerProgress;
      onLoaded?.Invoke();
    }

    private bool PlayerHaveProgress() =>
      File.Exists(FilePath.ProgressPath);
  }
}