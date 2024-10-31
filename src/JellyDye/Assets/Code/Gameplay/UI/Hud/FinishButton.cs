using Code.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.Hud
{
  public class FinishButton : MonoBehaviour
  {
    [SerializeField] private Button _finishButton;

    private FinishLevelService _finishLevelService;

    [Inject]
    public void Construct(FinishLevelService finishLevelService) =>
      _finishLevelService = finishLevelService;

    private void Awake() =>
      _finishButton.onClick.AddListener(FinishLevel);

    private void FinishLevel() =>
      _finishLevelService.FinishLevel().Forget();
  }
}