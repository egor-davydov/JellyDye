using Code.Services;
using Code.Services.Factories.UI;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Hud
{
  public class FinishButton : MonoBehaviour
  {
    [SerializeField] private Button _finishButton;
    
    private CameraService _cameraService;
    private GameObject _hudObject;
    private GameObject _syringeObject;
    private Tween _tween;
    private WindowFactory _windowFactory;

    [Inject]
    public void Construct(CameraService cameraService, WindowFactory windowFactory)
    {
      _windowFactory = windowFactory;
      _cameraService = cameraService;
    }

    public void Initialize(GameObject hudObject, GameObject syringeObject)
    {
      _syringeObject = syringeObject;
      _hudObject = hudObject;
    }
    
    private void Awake()
    {
      _finishButton.onClick.AddListener(FinishLevel);
    }

    private void OnDestroy()
    {
      _tween.Kill();
    }
    
    private void FinishLevel()
    {
      Destroy(_hudObject);
      Destroy(_syringeObject);
      Tween moveTween = _cameraService.MoveToFinish();
      moveTween.OnComplete(() => _windowFactory.CreateFinishWindow());
    }

  }
}