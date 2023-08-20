using System;
using System.Collections;
using System.Linq;
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
    [SerializeField] private NextSkinProgressBar _nextSkinProgressBar;
    [SerializeField] private RawImage _yourResultImage;
    [SerializeField] private RawImage _shouldBeImage;
    [SerializeField] private TextMeshProUGUI _percentageText;
    [SerializeField] private Transform _textTransform;
    [SerializeField] private float _appearanceAnimationDuration;
    [SerializeField] private float _percentageIncreaseTime;
    [SerializeField] private float _textIncreaseScale;
    [SerializeField] private float _scalingTime;
    [SerializeField] private int _levelFinishPercentageBonus = 5;
    [SerializeField, Range(0,1)] private float _skinProgressFor100Percent = 0.6f;

    private PaintCountCalculationService _paintCountCalculationService;
    private GreenButtonFactory _greenButtonFactory;
    private Tween _scaleTween;
    private ScreenshotService _screenshotService;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;
    private ISaveLoadService _saveLoadService;
    private LevelData _progressLevelData;

    [Inject]
    public void Construct(PaintCountCalculationService paintCountCalculationService,
      GreenButtonFactory greenButtonFactory, ScreenshotService screenshotService, ProgressService progressService,
      StaticDataService staticDataService, ISaveLoadService saveLoadService)
    {
      _saveLoadService = saveLoadService;
      _staticDataService = staticDataService;
      _progressService = progressService;
      _screenshotService = screenshotService;
      _greenButtonFactory = greenButtonFactory;
      _paintCountCalculationService = paintCountCalculationService;
      
      _progressLevelData = _progressService.Progress.LevelData;
    }

    private void Awake()
    {
      _shouldBeImage.texture = _staticDataService.ForLevels().LevelConfigs[_progressLevelData.CurrentLevelIndex].TargetTextureWithGround;
      _yourResultImage.texture = _screenshotService.ScreenshotTexture;
      AppearanceAnimation(StartWindowAnimations);
    }

    private void StartWindowAnimations()
    {
      StartCoroutine(PercentageIncrease());
      _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime);
    }

    private void AppearanceAnimation(Action onEnd)
    {
      transform.localScale = Vector3.zero;
      transform.DOScale(Vector3.one, _appearanceAnimationDuration).OnComplete(onEnd.Invoke);
    }

    private void OnDestroy()
    {
      _scaleTween.Kill();
    }

    private IEnumerator PercentageIncrease()
    {
      float yourPercentage = _paintCountCalculationService.CalculatePaintPercentage();
      float finalPercentage = RoundAndClampPercentage(yourPercentage + _levelFinishPercentageBonus);
      SetToProgress(finalPercentage);
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
      _nextSkinProgressBar.IncreaseProgress(_skinProgressFor100Percent / 100 * finalPercentage);
      SetPercentage(finalPercentage);
      _greenButtonFactory.CreateMenuButton(transform);
    }

    private void SetToProgress(float finalPercentage)
    {
      _progressLevelData.ManageCompletedLevel(_progressLevelData.CurrentLevelIndex, (int)finalPercentage);
      _saveLoadService.SaveProgress();
    }

    private void SetPercentage(float currentPercentage)
    {
      currentPercentage = RoundAndClampPercentage(currentPercentage);
      _percentageText.text = $"{currentPercentage}%";
    }

    private float RoundAndClampPercentage(float currentPercentage)
    {
      currentPercentage = (float)Math.Round(currentPercentage, 0);
      currentPercentage = Mathf.Clamp(currentPercentage, 0, 100);
      return currentPercentage;
    }
  }
}