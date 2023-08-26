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
    [SerializeField, Range(0,1)] private float _skinProgressFor100Percent;

    private PaintCountCalculationService _paintCountCalculationService;
    private GreenButtonFactory _greenButtonFactory;
    private ScreenshotService _screenshotService;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;
    private ISaveLoadService _saveLoadService;
    
    private LevelData _progressLevelData;
    private Tween _scaleTween;
    private float _finalPercentage;

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

    public void Initialize(Texture2D screenshot, Texture2D screenshotWithoutGround)
    {
      transform.localScale = Vector3.zero;
      SetImages(screenshot);
      CalculatePercentageResult();
      WriteToProgress(_finalPercentage, screenshotWithoutGround);
      transform.DOScale(Vector3.one, _appearanceAnimationDuration).OnComplete(StartWindowAnimations);
    }

    private void CalculatePercentageResult()
    {
      float yourPercentage = _paintCountCalculationService.CalculatePaintPercentage();
      _finalPercentage = RoundAndClampPercentage(yourPercentage);
    }

    private void SetImages(Texture2D screenshot)
    {
      _shouldBeImage.texture = _staticDataService.ForLevels().LevelConfigs[_progressLevelData.CurrentLevelIndex].TargetTextureWithGround;
      _yourResultImage.texture = screenshot;
    }

    private void OnDestroy() => 
      _scaleTween.Kill();

    private void StartWindowAnimations()
    {
      StartCoroutine(PercentageIncrease(_finalPercentage));
      _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime);
    }

    private IEnumerator PercentageIncrease(float finalPercentage)
    {
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

    private void WriteToProgress(float finalPercentage, Texture2D screenshotWithoutGround)
    {
      string resultImage = Convert.ToBase64String(screenshotWithoutGround.EncodeToPNG());
      _progressLevelData.ManageCompletedLevel(_progressLevelData.CurrentLevelIndex, (int)finalPercentage, resultImage);
      _saveLoadService.SaveProgress();
      
      //Destroy(temporaryTexture);
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