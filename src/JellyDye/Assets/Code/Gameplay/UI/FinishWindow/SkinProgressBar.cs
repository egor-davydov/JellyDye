using Code.Data;
using Code.Services.Progress;
using Code.StaticData.Skins;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class SkinProgressBar : MonoBehaviour
  {
    private const Ease FillTweenEase = Ease.OutQuad;

    [SerializeField] private GameObject[] _objectsToDisableIfPlayerHaveAllSkins;
    [SerializeField] private Image _nextSkinImage;
    [SerializeField] private Image _progressImage;
    [field: SerializeField] public float ProgressMoveTime { get; private set; }

    private Tween _fillTween;

    private ProgressService _progressService;

    [Inject]
    public void Construct(ProgressService progressService)
    {
      _progressService = progressService;
    }

    private SkinData SkinData => _progressService.Progress.SkinData;

    public void Initialize(bool isAllSkinsUnlockedBeforeSave, UnlockableSkinConfig nextSkinConfigBeforeSave)
    {
      if (isAllSkinsUnlockedBeforeSave)
        HideSkinObjects();
      else
        SetSkinIconAndFillAmount(nextSkinConfigBeforeSave.Icon, SkinData.NextSkinProgress);
    }

    private void OnDestroy() =>
      _fillTween.Kill();

    public void AnimateFill()
    {
      _fillTween = _progressImage.DOFillAmount(SkinData.NextSkinProgress, ProgressMoveTime).SetEase(FillTweenEase);
    }

    public Tween AnimateFillBeforeNewSkin(float fillDuration)
    {
      _fillTween = _progressImage.DOFillAmount(1, fillDuration)
        .SetEase(FillTweenEase);
      return _fillTween;
    }

    public void AnimateLastPartOrHideSkinObjects(bool isAllSkinsUnlockedAfterSave, float firstPartDuration, UnlockableSkinConfig nextSkinConfigAfterSave)
    {
      if (!isAllSkinsUnlockedAfterSave)
      {
        SetSkinIconAndFillAmount(nextSkinConfigAfterSave.Icon, 0);
        float lastPartDuration = ProgressMoveTime - firstPartDuration;
        _fillTween = _progressImage.DOFillAmount(SkinData.NextSkinProgress, lastPartDuration).SetEase(FillTweenEase);
      }
      else
      {
        HideSkinObjects();
      }
    }

    private void HideSkinObjects()
    {
      foreach (GameObject objectToDisableIfPlayerHaveAllSkin in _objectsToDisableIfPlayerHaveAllSkins)
        objectToDisableIfPlayerHaveAllSkin.SetActive(false);
    }

    private void SetSkinIconAndFillAmount(Sprite nextSkinIcon, float fillAmount)
    {
      _nextSkinImage.sprite = nextSkinIcon;
      _progressImage.fillAmount = fillAmount;
    }
  }
}