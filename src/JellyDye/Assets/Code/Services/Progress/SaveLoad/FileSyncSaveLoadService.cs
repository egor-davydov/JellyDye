using System;
using System.IO;
using Code.Constants;
using Code.Data;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class FileSyncSaveLoadService : ISaveLoadService
  {
    private readonly ProgressService _progressService;

    public FileSyncSaveLoadService(ProgressService progressService)
    {
      _progressService = progressService;
    }
    
    public void SaveProgress()
    {
      using FileStream fileStream = File.Create(FilePath.ProgressPath);
      using StreamWriter streamWriter = new StreamWriter(fileStream);
      streamWriter.WriteLine(JsonUtility.ToJson(_progressService.Progress));
    }
    
    public void LoadProgress(Action onLoaded = null)
    {
      if (PlayerHaveProgress() == false)
      {
        _progressService.CreateAndSetNewProgress();
        onLoaded?.Invoke();
        return;
      }
      
      using FileStream fileStream = File.Open(FilePath.ProgressPath, FileMode.Open);
      using StreamReader streamReader = new StreamReader(fileStream);
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(streamReader.ReadToEnd());
      _progressService.SetProgress(playerProgress);
      onLoaded?.Invoke();
    }

    private bool PlayerHaveProgress() => 
      File.Exists(FilePath.ProgressPath);
  }
}