using System;
using System.Collections;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
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
    [SerializeField] private TextMeshProUGUI _percentageText;
    [SerializeField] private Transform _textTransform;
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

    [Inject]
    public void Construct(PaintCountCalculationService paintCountCalculationService,
      GreenButtonFactory greenButtonFactory, ScreenshotService screenshotService, ProgressService progressService)
    {
      _progressService = progressService;
      _screenshotService = screenshotService;
      _greenButtonFactory = greenButtonFactory;
      _paintCountCalculationService = paintCountCalculationService;
    }

    private void Awake()
    {
      _yourResultImage.texture = _screenshotService.ScreenshotTexture;
      StartCoroutine(PercentageIncrease());
      _scaleTween = _textTransform.DOScale(Vector3.one * _textIncreaseScale, _scalingTime);
    }

    private void OnDestroy()
    {
      _scaleTween.Kill();
    }

    private IEnumerator PercentageIncrease()
    {
      float yourPercentage = _paintCountCalculationService.CalculatePaintPercentage();
      float finalPercentage = yourPercentage + _levelFinishPercentageBonus;
      Debug.Log($"yourPercentage= {yourPercentage}");
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

    private void SetPercentage(float currentPercentage)
    {
      currentPercentage = (float)Math.Round(currentPercentage, 0);
      currentPercentage = Mathf.Clamp(currentPercentage, 0, 100);
      _percentageText.text = $"{currentPercentage}%";
    }
  }
}