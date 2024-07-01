using Code.Gameplay.Syringe;
using Code.Gameplay.UI.Hud.PaintChange;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.Services.Providers;
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
      _backButton.onClick.AddListener(CloseMenu);
      _equippedSkinOnOpen = _progressService.Progress.SkinData.EquippedSkin;
    }

    private void CloseMenu()
    {
      SkinType equippedSkinOnClose = _progressService.Progress.SkinData.EquippedSkin;
      if (equippedSkinOnClose != _equippedSkinOnOpen)
      {
        Vector3 previousSyringePosition = _syringeProvider.SyringeObject.transform.position;
        Destroy(_syringeProvider.SyringeObject);
        GameObject syringeObject = _syringeFactory.CreateSyringe(
          equippedSkinOnClose,
          previousSyringePosition);
        _syringeProvider.Initialize(syringeObject);
      
        _syringeProvider.SyringeInjection.Initialize(_hudProvider.InjectionButton);
        Color currentSelectedColor = _hudProvider.JarsContainer.CurrentSelectedColor;
        _syringeProvider.SyringePaintColor.ChangeLiquidColor(currentSelectedColor);
        _syringeProvider.SyringeInjection.SyringeReset();
      }
      Destroy(_menuObject);
    }
  }
}