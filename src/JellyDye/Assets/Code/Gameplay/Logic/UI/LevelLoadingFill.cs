using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Code.Gameplay.Logic.UI
{
  public class LevelLoadingFill : MonoBehaviour
  {
    [SerializeField] private Image _loadingFillImage;

    public async UniTaskVoid StartFill(List<AsyncOperationHandle> loadingOperations)
    {
      while (_loadingFillImage.fillAmount != 1)
      {
        _loadingFillImage.fillAmount = loadingOperations.Average(x => x.PercentComplete);
        await UniTask.NextFrame(this.GetCancellationTokenOnDestroy());
      }
    }
  }
}