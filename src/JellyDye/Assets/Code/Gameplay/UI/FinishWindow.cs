using System;
using System.Collections;
using Code.Services;
using Code.Services.Factories.UI;
using DG.Tweening;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI
{
  public class FinishWindow : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _percentageText;
    [SerializeField] private Transform _textTransform;
    [SerializeField] private float _percentageIncreaseTime;
    [SerializeField] private float _textIncreaseScale;
    [SerializeField] private float _scalingTime;
    [SerializeField] private int _levelFinishPercentageBonus = 5;

    private PaintCountCalculationService _paintCountCalculationService;
    private GreenButtonFactory _greenButtonFactory;
    private Tween _scaleTween;

    [Inject]
    public void Construct(PaintCountCalculationService paintCountCalculationService, GreenButtonFactory greenButtonFactory)
    {
      _greenButtonFactory = greenButtonFactory;
      _paintCountCalculationService = paintCountCalculationService;
    }

    private void Awake()
    {
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

      SetPercentage(finalPercentage);
      _scaleTween = _textTransform.DOScale(Vector3.one, _scalingTime);
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