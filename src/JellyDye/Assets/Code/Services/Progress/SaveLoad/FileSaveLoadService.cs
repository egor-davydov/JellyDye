using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks;
using Code.Data;
using Code.Infrastructure;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class FileSaveLoadService : ISaveLoadService
  {
    public static readonly string ProgressFilePath = $"{Application.persistentDataPath}/Progress.dat";
    
    private readonly ProgressService _progressService;
    private readonly ICoroutineRunner _coroutineRunner;

    public FileSaveLoadService(ProgressService progressService, ICoroutineRunner coroutineRunner)
    {
      _progressService = progressService;
      _coroutineRunner = coroutineRunner;
    }
    
    public void SaveProgress()
    {
      using FileStream fileStream = File.Create(ProgressFilePath);
      using StreamWriter streamWriter = new StreamWriter(fileStream);
      streamWriter.WriteLine(JsonUtility.ToJson(_progressService.Progress));
    }
    
    public void LoadProgressAsync(Action onLoaded = null)
    {
      if (PlayerHaveProgress() == false)
      {
        _progressService.CreateProgress();
        onLoaded?.Invoke();
        return;
      }
      _coroutineRunner.StartCoroutine(ReadDataFromFile(onLoaded));
    }

    private IEnumerator ReadDataFromFile(Action onLoaded = null)
    {
      using FileStream fileStream = File.Open(ProgressFilePath, FileMode.Open);
      using StreamReader streamReader = new StreamReader(fileStream);
      Task<string> readingTask = streamReader.ReadToEndAsync();
      
      if (!readingTask.IsCompleted)
        yield return null;
      
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(readingTask.Result);
      _progressService.SetProgress(playerProgress);
      onLoaded?.Invoke();
    }

    private bool PlayerHaveProgress() => 
      File.Exists(ProgressFilePath);
  }
}