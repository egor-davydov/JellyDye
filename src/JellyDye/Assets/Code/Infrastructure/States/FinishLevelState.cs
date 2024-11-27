using System.Linq;
using Code.Gameplay.UI.FinishWindow;
using Code.Infrastructure.States.Interfaces;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Code.Services.Providers;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class FinishLevelState : IState
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly AnimatedButtonFactory _animatedButtonFactory;
    private readonly CameraService _cameraService;
    private readonly ScreenshotService _screenshotService;
    private readonly WindowFactory _windowFactory;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;
    private readonly StaticDataService _staticData;
    private readonly PublishService _publishService;
    private readonly AnalyticsService _analyticsService;
    private readonly ProgressService _progress;
    private readonly ISaveLoadService _saveLoadService;
    private readonly NewSkinSceneService _newSkinSceneService;

    public FinishLevelState(PaintCountCalculationService paintCountCalculationService,
      AnimatedButtonFactory animatedButtonFactory, CameraService cameraService, ScreenshotService screenshotService,
      WindowFactory windowFactory, SyringeProvider syringeProvider, HudProvider hudProvider,
      StaticDataService staticData, PublishService publishService, AnalyticsService analyticsService,
      ProgressService progress, ISaveLoadService saveLoadService, NewSkinSceneService newSkinSceneService)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _animatedButtonFactory = animatedButtonFactory;
      _cameraService = cameraService;
      _screenshotService = screenshotService;
      _windowFactory = windowFactory;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
      _staticData = staticData;
      _publishService = publishService;
      _analyticsService = analyticsService;
      _progress = progress;
      _saveLoadService = saveLoadService;
      _newSkinSceneService = newSkinSceneService;
    }

    public async UniTaskVoid Enter()
    {
      UniTask<float> calculatePaintPercentageTask = _paintCountCalculationService.CalculatePaintPercentageAsync();
      Object.Destroy(_hudProvider.HudObject);
      Object.Destroy(_syringeProvider.SyringeObject);
      await AnimateAndShowCameraFlash();

      int roundedPercentage = Mathf.RoundToInt(await calculatePaintPercentageTask);
      float increaseAmount = _staticData.ForSkins.MinSkinProgress * ((float)roundedPercentage / 100);
      float currentAmount = _progress.ForSkins.NextSkinProgress;
      if (_staticData.ForDevelopHelpers.OpenNewSkin)
      {
        roundedPercentage = 100;
        increaseAmount = 1;
      }

      bool isAllSkinsUnlockedBeforeSave = IsAllSkinsUnlocked();
      UnlockableSkinConfig nextSkinConfigBeforeSave = !isAllSkinsUnlockedBeforeSave ? GetNextSkinConfig() : null;
      bool isSkinProgressChanged = increaseAmount != 0 && !isAllSkinsUnlockedBeforeSave;
      bool isProgressBarWillBeFilled = IsProgressBarWillBeFilled(currentAmount, increaseAmount);

      SetAndSaveProgress(roundedPercentage, isSkinProgressChanged, isProgressBarWillBeFilled, increaseAmount, nextSkinConfigBeforeSave);
      SendAnalyticsSetLeaderboardRequestReview(roundedPercentage);

      Texture2D screenshot = await _screenshotService.TakeScreenshotAsync();
      FinishWindow finishWindow = await CreateFinishWindow(screenshot);
      SkinProgressBar skinProgressBar = finishWindow.SkinProgressBar;
      skinProgressBar.Initialize(isAllSkinsUnlockedBeforeSave, nextSkinConfigBeforeSave, currentAmount);

      await AnimateFinishWindow(finishWindow, roundedPercentage);
      if (isSkinProgressChanged)
        await AnimateSkinProgressBarAsync(isProgressBarWillBeFilled, skinProgressBar, currentAmount, increaseAmount, nextSkinConfigBeforeSave);

      _animatedButtonFactory.CreateNextLevelButton(finishWindow.transform).Forget();
    }

    public UniTaskVoid Exit() =>
      default;

    private async UniTask AnimateFinishWindow(FinishWindow finishWindow, int roundedPercentage)
    {
      await finishWindow.AnimateWindowAppearanceAsync();
      await finishWindow.AnimatePercentageTextAsync(roundedPercentage);
    }

    private async UniTask AnimateSkinProgressBarAsync(bool isProgressBarWillBeFilled, SkinProgressBar skinProgressBar, float currentAmount, float increaseAmount, UnlockableSkinConfig nextSkinConfigBeforeSave)
    {
      bool isAllSkinsUnlockedAfterSave = IsAllSkinsUnlocked();
      UnlockableSkinConfig nextSkinConfigAfterSave = !isAllSkinsUnlockedAfterSave ? GetNextSkinConfig() : null;

      if (!isProgressBarWillBeFilled)
      {
        skinProgressBar.AnimateFill();
      }
      else
      {
        float fillDuration = isAllSkinsUnlockedAfterSave
          ? skinProgressBar.ProgressMoveTime
          : skinProgressBar.ProgressMoveTime * ((1 - currentAmount) / increaseAmount);
        await skinProgressBar.AnimateFillBeforeNewSkin(fillDuration);

        await _newSkinSceneService.ShowSkinScene(nextSkinConfigBeforeSave.SkinType);
        await _newSkinSceneService.HideSkinScene();
        skinProgressBar.AnimateLastPartOrHideSkinObjects(isAllSkinsUnlockedAfterSave, fillDuration, nextSkinConfigAfterSave);
      }
    }

    private void SetAndSaveProgress(int roundedPercentage, bool isSkinProgressChanged, bool isProgressWillBeFilled,
      float increaseAmount, UnlockableSkinConfig nextSkinConfigBeforeSave)
    {
      _progress.ForLevels.ManageCompletedLevel(_progress.ForLevels.CurrentLevelId, roundedPercentage);
      if (isSkinProgressChanged)
      {
        _progress.ForSkins.UpdateNextSkinProgress(isProgressWillBeFilled, increaseAmount);
        if (isProgressWillBeFilled)
          _progress.ForSkins.OpenSkin(nextSkinConfigBeforeSave.SkinType);
      }

      _saveLoadService.SaveProgress();
    }

    private void SendAnalyticsSetLeaderboardRequestReview(int roundedPercentage)
    {
      int levelIndex = _staticData.ForLevels.GetLevelIndex(_progress.ForLevels.CurrentLevelId);
      _analyticsService.LevelEnd(levelIndex, _progress.ForLevels.CurrentLevelId, roundedPercentage);
      _publishService.SetToLeaderboard(_progress.ForLevels.CompletedLevels.Sum(level => level.Percentage));
      if (_progress.ForLevels.CompletedLevels.Count >= 3)
        _publishService.RequestCanPlayerReviewOrNot(OnServerReviewResponse);
    }

    private async UniTask AnimateAndShowCameraFlash()
    {
      await _cameraService.MoveToFinish();
      await UniTask.WaitForSeconds(1 - _cameraService.LevelCamera.MovingTime);
      await _cameraService.ShowPhotoFlash();
    }

    private async UniTask<FinishWindow> CreateFinishWindow(Texture2D screenshot)
    {
      GameObject finishWindowObject = await _windowFactory.CreateFinishWindow();
      FinishWindow finishWindow = finishWindowObject.GetComponent<FinishWindow>();
      finishWindow.Initialize(screenshot);
      return finishWindow;
    }

    public bool IsAllSkinsUnlocked()
    {
      return _staticData.ForSkins.UnlockableSkins
        .All(unlockableSkinConfig => _progress.ForSkins.IsPlayerHaveSkin(unlockableSkinConfig.SkinType));
    }

    public bool IsProgressBarWillBeFilled(float currentAmount, float increaseAmount) =>
      currentAmount + increaseAmount >= 1;

    private void OnServerReviewResponse(bool isPlayerCanReview)
    {
      if (isPlayerCanReview)
        ShowReviewWindow();
    }

    private void ShowReviewWindow()
    {
      Time.timeScale = 0;
      _publishService.ShowReviewGameWindow(OnPlayerReviewWindowAction);
    }

    private void OnPlayerReviewWindowAction(bool value) =>
      Time.timeScale = 1;

    private UnlockableSkinConfig GetNextSkinConfig() =>
      _staticData.ForSkins.UnlockableSkins.First(config => !_progress.ForSkins.IsPlayerHaveSkin(config.SkinType));
  }
}