using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Logic
{
  public class LoadingCurtain : MonoBehaviour
  {
    [SerializeField] private Image _loadingFillImage;

    public void FillLoadingProgress(float loadingProgress) => 
      _loadingFillImage.fillAmount = loadingProgress;

    public void Show() =>
      gameObject.SetActive(true);

    public void Hide() =>
      gameObject.SetActive(false);
  }
}