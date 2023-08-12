using System.IO;
using Code.Data;
using UnityEngine;

namespace Code.Services.Progress.SaveLoad
{
  public class FileSaveLoadService : ISaveLoadService
  {
    public static readonly string ProgressFilePath = $"{Application.persistentDataPath}/Progress.dat";
    
    private readonly ProgressService _progressService;

    public FileSaveLoadService(ProgressService progressService)
    {
      _progressService = progressService;
    }
    
    public void SaveProgress()
    {
      using FileStream fileStream = File.Create(ProgressFilePath);
      using StreamWriter streamWriter = new StreamWriter(fileStream);
      streamWriter.WriteLine(JsonUtility.ToJson(_progressService.Progress));
    }
    
    public PlayerProgress LoadProgress()
    {
      using FileStream fileStream = File.Open(ProgressFilePath, FileMode.Open);
      using StreamReader streamReader = new StreamReader(fileStream);
      PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(streamReader.ReadToEnd());

      return playerProgress;
    }

    public bool IsPlayerHaveProgress() => 
      File.Exists(ProgressFilePath);
  }
}