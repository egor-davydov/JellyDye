using Code.Enums;
using Code.Gameplay.Syringe;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services.LevelLoad
{
  public class LevelInitializationService
  {
    private readonly HudFactory _hudFactory;
    private readonly SyringeFactory _syringeFactory;
    private readonly JelliesFactory _jelliesFactory;
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;
    private readonly ParentsProvider _parentsProvider;
    private readonly PublishService _publishService;
    private readonly SceneLoader _sceneLoader;
    private readonly LevelRestartService _levelRestartService;
    private readonly SyringeService _syringeService;
    private readonly LevelChangeService _levelChangeService;
    private readonly WindowsService _windowsService;
    private readonly ProgressService _progress;

    public LevelInitializationService(HudFactory hudFactory, SyringeFactory syringeFactory, JelliesFactory jelliesFactory,
      ProgressService progress, PaintCountCalculationService paintCountCalculationService, SyringeProvider syringeProvider,
      HudProvider hudProvider, ParentsProvider parentsProvider, LevelRestartService levelRestartService,
      SyringeService syringeService, LevelChangeService levelChangeService, WindowsService windowsService)
    {
      _hudFactory = hudFactory;
      _syringeFactory = syringeFactory;
      _jelliesFactory = jelliesFactory;
      _progress = progress;
      _paintCountCalculationService = paintCountCalculationService;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
      _parentsProvider = parentsProvider;
      _levelRestartService = levelRestartService;
      _syringeService = syringeService;
      _levelChangeService = levelChangeService;
      _windowsService = windowsService;
    }

    public async UniTask SetupLevel(string levelId)
    {
      await _windowsService.CreateAndInitializeWindowsAsync();

      GameObject jelliesObject = await _jelliesFactory.CreateJelly(levelId);
      _levelChangeService.Initialize(jelliesObject);
      _paintCountCalculationService.Initialize(jelliesObject);
      _levelRestartService.Initialize(jelliesObject);

      await CreateAndInitSyringe();
      await CreateAndInitHud(levelId);
      _syringeProvider.Syringe.Initialize(_hudProvider.InjectionButton);
    }

    private async UniTask CreateAndInitSyringe()
    {
      SkinType equippedSkin = _progress.ForSkins.EquippedSkin;
      Syringe syringe = await _syringeFactory.Create(equippedSkin, _parentsProvider.ParentForGameplay);
      _syringeProvider.Initialize(syringe);
      _syringeService.ResetSyringe();
    }

    private async UniTask CreateAndInitHud(string levelId)
    {
      GameObject hudObject = await _hudFactory.CreateHud();
      _hudProvider.Initialize(hudObject);
      _hudProvider.JarsContainer.InitializeAndCreateJars(levelId).Forget();
      _hudProvider.ScreenshotTargetColors.Initialize(levelId);
    }
  }
}