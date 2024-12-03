using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu
{
  public class BackToLevelButton : MonoBehaviour
  {
    [SerializeField] private GameObject _menuObject;
    [SerializeField] private Button _backButton;

    private SkinType _equippedSkinOnOpen;
    private SyringeService _syringeService;

    [Inject]
    public void Construct(SyringeService syringeService)
    {
      _syringeService = syringeService;
    }

    private void Awake() =>
      _backButton.onClick.AddListener(UniTask.UnityAction(CloseMenu));

    private async UniTaskVoid CloseMenu()
    {
      await _syringeService.ReplaceSkinIfChanged();
      Destroy(_menuObject);
    }
  }
}