﻿using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Code.StaticData.Skins;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class NextSkinProgressBar : MonoBehaviour
  {
    private const Ease FillTweenEase = Ease.OutQuad;

    [SerializeField] private GameObject[] _objectsToDisableIfPlayerHaveAllSkins;
    [SerializeField] private Image _nextSkinImage;
    [SerializeField] private Image _progressImage;
    [SerializeField] private float _progressMoveTime = 1f;

    private ISaveLoadService _saveLoadService;
    private ProgressService _progressService;
    private StaticDataService _staticDataService;

    private float _finalFillAmount;
    private Tween _fillTween;
    private UnlockableSkinConfig[] _unlockableSkinConfigs;
    private List<SkinType> _openedSkinTypes;
    private UnlockableSkinConfig _nextSkinConfig;

    [Inject]
    public void Construct(ProgressService progressService, ISaveLoadService saveLoadService, StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
      _progressService = progressService;
      _saveLoadService = saveLoadService;

      _unlockableSkinConfigs = _staticDataService.ForSkins().UnlockableSkins;
      _openedSkinTypes = _progressService.Progress.SkinData.OpenedSkins;
    }

    private void Awake()
    {
      if (AllSkinsUnlocked())
        HideSkinObject();
      else
      {
        SetupNextSkin();
        _progressImage.fillAmount = _progressService.Progress.SkinData.NextSkinProgress;
      }
    }

    private void OnDestroy()
    {
      _fillTween.Kill();
    }

    public void IncreaseProgress(float quantity)
    {
      if (AllSkinsUnlocked())
        return;
      
      if (_progressImage.fillAmount + quantity < 1)
      {
        _finalFillAmount = _progressImage.fillAmount + quantity;
        _fillTween = _progressImage.DOFillAmount(_finalFillAmount, _progressMoveTime).SetEase(FillTweenEase);
      }
      else
      {
        _finalFillAmount = _progressImage.fillAmount + quantity - 1;
        _fillTween = _progressImage
          .DOFillAmount(1, _progressMoveTime).SetEase(FillTweenEase)
          .OnComplete(OnProgressFilled);
      }

      _progressService.Progress.SkinData.NextSkinProgress = _finalFillAmount;
      _saveLoadService.SaveProgress();
    }

    private bool AllSkinsUnlocked() =>
      _unlockableSkinConfigs.All(unlockableSkinConfig => !PlayerDontHaveSkin(unlockableSkinConfig.SkinType));

    private UnlockableSkinConfig FindOutNextSkin()
    {
      foreach (UnlockableSkinConfig unlockableSkinConfig in _unlockableSkinConfigs)
      {
        if (PlayerDontHaveSkin(unlockableSkinConfig.SkinType))
          return unlockableSkinConfig;
      }

      throw new Exception("Cant find next skin config");
    }

    private bool PlayerDontHaveSkin(SkinType observableSkinType) =>
      _openedSkinTypes.All(skinType => skinType != observableSkinType);

    private void OnProgressFilled()
    {
      _progressService.Progress.SkinData.OpenedSkins.Add(_nextSkinConfig.SkinType);
      _saveLoadService.SaveProgress();
      if (AllSkinsUnlocked())
        HideSkinObject();
      else
      {
        SetupNextSkin();
        _progressImage.fillAmount = 0;
        _progressImage.DOFillAmount(_finalFillAmount, _progressMoveTime).SetEase(FillTweenEase);
      }
    }

    private void HideSkinObject()
    {
      foreach (GameObject objectToDisableIfPlayerHaveAllSkin in _objectsToDisableIfPlayerHaveAllSkins)
        objectToDisableIfPlayerHaveAllSkin.SetActive(false);
    }

    private void SetupNextSkin()
    {
      _nextSkinConfig = FindOutNextSkin();
      _nextSkinImage.sprite = _nextSkinConfig.Icon;
    }
  }
}