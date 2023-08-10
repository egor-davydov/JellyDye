using Code.Services;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Hud
{
  public class FinishButton : MonoBehaviour
  {
    [SerializeField] private Button _finishButton;
    [SerializeField] private float _moveTime;
    private CameraService _cameraService;
    private GameObject _hudObject;
    private GameObject _syringeObject;

    [Inject]
    public void Construct(CameraService cameraService)
    {
      _cameraService = cameraService;
    }

    public void Initialize(GameObject hudObject, GameObject syringeObject)
    {
      _syringeObject = syringeObject;
      _hudObject = hudObject;
    }
    
    private void Awake()
    {
      ((RectTransform)transform).DOAnchorPos(Vector2.zero, _moveTime);
      _finishButton.onClick.AddListener(FinishLevel);
    }

    private void FinishLevel()
    {
      Destroy(_hudObject);
      Destroy(_syringeObject);
      _cameraService.MoveToFinish();
    }
  }
}