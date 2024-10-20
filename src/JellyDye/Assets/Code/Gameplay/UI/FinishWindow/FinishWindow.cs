using System;
using System.Linq;
using Code.Data;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class FinishWindow : MonoBehaviour
  {
    [SerializeField] private SkinProgressBar _skinProgressBar;
    [SerializeField] private RawImage _yourResultImage;
    [SerializeField] private RawImage _shouldBeImage;
    [SerializeField] private TextMeshProUGUI _percentageText;
    [SerializeField] private Transform _textTransform;
    [SerializeField] private Transform _resultsTransform;
    [SerializeField] private float _appearanceAnimationDuration;
    [SerializeField] private float _percentageIncreaseTime;
    [SerializeField] private float _textIncreaseScale;
    [SerializeField] private float _scalingTime;

    private AnimatedButtonFactory _animatedButtonFactory;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;
    private ISaveLoadService _saveLoadService;

    private LevelData _progressLevelData;
    private Tween _scaleTween;
    private PublishService _publishService;
    private AnalyticsService _analyticsService;
    private StringsService _stringsService;

    [Inject]
    public void Construct(AnimatedButtonFactory animatedButtonFactory, ProgressService progressService,
      StaticDataService staticDataService, ISaveLoadService saveLoadService,
      PublishService publishService, AnalyticsService analyticsService, StringsService stringsService)
    {
      _stringsService = stringsService;
      _analyticsService = analyticsService;
      _publishService = publishService;
      _saveLoadService = saveLoadService;
      _staticDataService = staticDataService;
      _progressService = progressService;
      _animatedButtonFactory = animatedButtonFactory;

      _progressLevelData = _progressService.Progress.LevelData;
    }

    public void Initialize(Texture2D screenshot)
    {
      _shouldBeImage.texture = _staticDataService.ForLevels().GetConfigByLevelId(_progressLevelData.CurrentLevelId)
        .TargetTextureWithGround;
      _yourResultImage.texture = screenshot;
    }

    private void OnDestroy() =>
      _scaleTween.Kill();

    public void AnimateWindowAppearance(Action onEnd)
    {
      _resultsTransform.localScale = Vector3.zero;
      _resultsTransform.DOScale(Vector3.one, _appearanceAnimationDuration).OnComplete(onEnd.Invoke);
    }

    public async UniTaskVoid AnimatePercentageText(float percentage)
    {
      float finalPercentage = RoundAndClampPercentage(percentage);
      finalPercentage = 100;
      float skinProgressBarIncreaseAmount = _staticDataService.ForSkins().MinSkinProgress * (finalPercentage / 100);
      UpdatePlayerProgress(finalPercentage, skinProgressBarIncreaseAmount);
      _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime);
      _publishService.SetToLeaderboard(_progressLevelData.CompletedLevels.Sum(level => level.Percentage));
      OnLevelEnd(finalPercentage);
      await PercentageIncrease(finalPercentage);
      _scaleTween = _textTransform.DOScale(Vector3.one, _scalingTime);
      await _skinProgressBar.IncreaseProgress(skinProgressBarIncreaseAmount);
      CreateNextLevelButton().Forget();
    }

    private async UniTask PercentageIncrease(float percentage)
    {
      float currentTime = 0;
      while (currentTime < _percentageIncreaseTime)
      {
        currentTime += Time.deltaTime;
        float currentPercentage = Mathf.Lerp(0, percentage, currentTime / _percentageIncreaseTime);
        SetPercentage(currentPercentage);
        await UniTask.NextFrame(this.GetCancellationTokenOnDestroy());
      }

      SetPercentage(percentage);
    }

    private async UniTaskVoid CreateNextLevelButton() =>
      await _animatedButtonFactory.CreateNextLevelButton(transform);

    private void OnLevelEnd(float finalPercentage)
    {
      _analyticsService.LevelEnd(_staticDataService.ForLevels().GetLevelIndex(_progressLevelData.CurrentLevelId),
        _progressLevelData.CurrentLevelId, (int)finalPercentage);

      if (_progressLevelData.CompletedLevels.Count >= 3)
        _publishService.RequestCanPLayerReviewOrNot(OnServerReviewResponse);
    }

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

    private void UpdatePlayerProgress(float finalPercentage, float increaseAmount)
    {
      _progressLevelData.ManageCompletedLevel(_progressLevelData.CurrentLevelId, (int)finalPercentage);
      _skinProgressBar.CalculateAndSetProgress(increaseAmount);
      _saveLoadService.SaveProgress();
    }

    private void SetPercentage(float currentPercentage)
    {
      currentPercentage = RoundAndClampPercentage(currentPercentage);
      _percentageText.text = _stringsService.Percentages[(int)currentPercentage];
    }

    private float RoundAndClampPercentage(float currentPercentage)
    {
      currentPercentage = Mathf.RoundToInt(currentPercentage);
      currentPercentage = Mathf.Clamp(currentPercentage, 0, 100);
      return currentPercentage;
    }
  }
}