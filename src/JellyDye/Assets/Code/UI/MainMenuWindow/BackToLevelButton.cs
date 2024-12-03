using Code.Enums;
using Code.Services;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.MainMenuWindow
{
  public class BackToLevelButton : MonoBehaviour
  {
    [SerializeField] private MainMenuWindow _mainMenuWindow;
    [SerializeField] private Button _backButton;

    private SkinType _equippedSkinOnOpen;
    private SyringeService _syringeService;

    [Inject]
    public void Construct(SyringeService syringeService)
    {
      _syringeService = syringeService;
    }

    private void Awake() =>
      _backButton.onClick.AddListener(UniTask.UnityAction(OnBackToLevelButtonClick));

    private async UniTaskVoid OnBackToLevelButtonClick()
    {
      await _syringeService.ReplaceSkinIfChanged();
      _mainMenuWindow.CloseWindow();
    }
  }
}