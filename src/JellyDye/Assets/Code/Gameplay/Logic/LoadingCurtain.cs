using Code.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Logic
{
  public class LoadingCurtain : MonoBehaviour
  {
    [SerializeField] private Image _loadingFillImage;
    private SceneLoader _sceneLoader;

    [Inject]
    public void Construct(SceneLoader sceneLoader) => 
      _sceneLoader = sceneLoader;

    public void Update() => 
      _loadingFillImage.fillAmount = _sceneLoader.LoadProgress;
  }
}