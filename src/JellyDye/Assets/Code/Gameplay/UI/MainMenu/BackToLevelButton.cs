using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.Services.Providers;
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

    private SyringeFactory _syringeFactory;
    private ProgressService _progressService;
    private SyringeProvider _syringeProvider;
    private HudProvider _hudProvider;
    private SkinType _equippedSkinOnOpen;

    [Inject]
    public void Construct(SyringeFactory syringeFactory, ProgressService progressService,
      SyringeProvider syringeProvider, HudProvider hudProvider)
    {
      _hudProvider = hudProvider;
      _syringeProvider = syringeProvider;
      _progressService = progressService;
      _syringeFactory = syringeFactory;
    }

    private void Awake()
    {
      _backButton.onClick.AddListener(UniTask.UnityAction(CloseMenu));
      _equippedSkinOnOpen = _progressService.Progress.SkinData.EquippedSkin;
    }

    private async UniTaskVoid CloseMenu()
    {
      await ChangeSkinIfNeeded();
      Destroy(_menuObject);
    }

    private async UniTask ChangeSkinIfNeeded()
    {
      SkinType equippedSkinOnClose = _progressService.Progress.SkinData.EquippedSkin;
      if (equippedSkinOnClose != _equippedSkinOnOpen && !SyringeAlreadyDestroyed())
      {
        Transform previousSyringeTransform = _syringeProvider.SyringeObject.transform;
        GameObject syringeObject = await _syringeFactory.Create(
          equippedSkinOnClose,
          previousSyringeTransform.position,
          previousSyringeTransform.rotation,
          previousSyringeTransform.parent);
        Destroy(_syringeProvider.SyringeObject);
        _syringeProvider.Initialize(syringeObject);

        _syringeProvider.SyringeInjection.Initialize(_hudProvider.InjectionButton);
        Color currentSelectedColor = _hudProvider.JarsContainer.CurrentSelectedColor;
        _syringeProvider.SyringeLiquidColor.ChangeLiquidColor(currentSelectedColor);
        _syringeProvider.SyringeInjection.SyringeReset();
      }
    }

    private bool SyringeAlreadyDestroyed() =>
      _syringeProvider.SyringeObject == null;
  }
}