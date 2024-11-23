using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using UnityEngine;
using Zenject;

namespace Code.Helpers
{
  public class DeleteYandexCloudProgress : MonoBehaviour
  {
    private ISaveLoadService _saveLoadService;
    private ProgressService _progress;

    [Inject]
    public void Construct(ISaveLoadService saveLoadService, ProgressService progressService)
    {
      _progress = progressService;
      _saveLoadService = saveLoadService;
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.C))
      {
        _progress.CreateAndSetStartProgress();
        _saveLoadService.SaveProgress();
      }
    }
  }
}