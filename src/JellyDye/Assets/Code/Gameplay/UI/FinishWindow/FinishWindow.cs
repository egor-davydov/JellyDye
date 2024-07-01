using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Code.Data;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
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
    [SerializeField] private float _appearanceAnimationDuration;
    [SerializeField] private float _percentageIncreaseTime;
    [SerializeField] private float _textIncreaseScale;
    [SerializeField] private float _scalingTime;

    private PaintCountCalculationService _paintCountCalculationService;
    private GreenButtonFactory _greenButtonFactory;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;
    private ISaveLoadService _saveLoadService;

    private LevelData _progressLevelData;
    private Tween _scaleTween;
    private PublishService _publishService;
    private AnalyticsService _analyticsService;

    [Inject]
    public void Construct(PaintCountCalculationService paintCountCalculationService,
      GreenButtonFactory greenButtonFactory, ProgressService progressService,
      StaticDataService staticDataService, ISaveLoadService saveLoadService,
      PublishService publishService, AnalyticsService analyticsService)
    {
      _analyticsService = analyticsService;
      _publishService = publishService;
      _saveLoadService = saveLoadService;
      _staticDataService = staticDataService;
      _progressService = progressService;
      _greenButtonFactory = greenButtonFactory;
      _paintCountCalculationService = paintCountCalculationService;

      _progressLevelData = _progressService.Progress.LevelData;
    }

    public void Initialize(Texture2D screenshot)
    {
      _shouldBeImage.texture = _staticDataService.ForLevels().GetConfigByLevelId(_progressLevelData.CurrentLevelId).TargetTextureWithGround;
      _yourResultImage.texture = screenshot;
      StartAppearanceAnimation(onEnd: StartWindowAnimations);
    }

    private void OnDestroy() =>
      _scaleTween.Kill();

    private void StartWindowAnimations()
    {
      _paintCountCalculationService.AsyncCalculatePaintPercentage(percentage =>
      {
        _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime);
        StartCoroutine(PercentageIncrease(percentage));
      });
    }

    private void StartAppearanceAnimation(Action onEnd)
    {
      transform.localScale = Vector3.zero;
      transform.DOScale(Vector3.one, _appearanceAnimationDuration).OnComplete(onEnd.Invoke);
    }

    private IEnumerator PercentageIncrease(float yourPercentage)
    {
      float finalPercentage = RoundAndClampPercentage(yourPercentage);
      WriteToProgress(finalPercentage);
      _publishService.SetToLeaderboard(_progressLevelData.CompletedLevels.Sum(level => level.Percentage));
      OnLevelEnd(finalPercentage);
      //Debug.Log($"yourPercentage= {yourPercentage}");
      float currentTime = 0;
      while (currentTime < _percentageIncreaseTime)
      {
        currentTime += Time.deltaTime;
        float currentPercentage = Mathf.Lerp(0, finalPercentage, currentTime / _percentageIncreaseTime);
        SetPercentage(currentPercentage);
        yield return null;
      }

      _scaleTween = _textTransform.DOScale(Vector3.one, _scalingTime);
      _skinProgressBar.IncreaseProgress(finalPercentage);
      SetPercentage(finalPercentage);
      CreateNextLevelButton();
    }

    private async void CreateNextLevelButton() =>
      await _greenButtonFactory.CreateNextLevelButton(transform);

    private void OnLevelEnd(float finalPercentage)
    {
      _analyticsService.LevelEnd(_staticDataService.ForLevels().GetLevelIndex(_progressLevelData.CurrentLevelId), _progressLevelData.CurrentLevelId, (int)finalPercentage);

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

    private void WriteToProgress(float finalPercentage)
    {
      _progressLevelData.ManageCompletedLevel(_progressLevelData.CurrentLevelId, (int)finalPercentage);
      _saveLoadService.SaveProgress();
    }

    private void SetPercentage(float currentPercentage)
    {
      currentPercentage = RoundAndClampPercentage(currentPercentage);
      _percentageText.text = $"{currentPercentage}%";
    }

    private float RoundAndClampPercentage(float currentPercentage)
    {
      currentPercentage = Mathf.RoundToInt(currentPercentage);
      currentPercentage = Mathf.Clamp(currentPercentage, 0, 100);
      return currentPercentage;
    }
  }
}