using Code.Services.Progress;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.FinishWindow
{
  public class SkinProgressBar : MonoBehaviour
  {
    private const Ease FillTweenEase = Ease.OutQuad;

    [SerializeField] private GameObject[] _objectsToDisableIfPlayerHaveAllSkins;
    [SerializeField] private Image _nextSkinImage;
    [SerializeField] private Image _progressImage;
    [field: SerializeField] public float ProgressMoveTime { get; private set; }


    private ProgressService _progress;
    private TweenerCore<float, float, FloatOptions> _fillTweenFullTime;

    [Inject]
    public void Construct(ProgressService progressService)
    {
      _progress = progressService;
    }

    public void Initialize(bool isAllSkinsUnlockedBeforeSave, UnlockableSkinConfig nextSkinConfigBeforeSave, float currentAmount)
    {
      if (isAllSkinsUnlockedBeforeSave)
        HideSkinObjects();
      else
        SetSkinIconAndFillAmount(nextSkinConfigBeforeSave.Icon, currentAmount);
    }

    private void Awake()
    {
      _fillTweenFullTime = _progressImage.DOFillAmount(default, ProgressMoveTime)
        .SetEase(FillTweenEase).SetLink(gameObject).SetAutoKill(false);
    }

    public void AnimateFill()
    {
      _fillTweenFullTime.ChangeValues(_progressImage.fillAmount, _progress.ForSkins.NextSkinProgress);
      _fillTweenFullTime.Restart();
    }

    public UniTask AnimateFillBeforeNewSkinAsync(float duration)
    {
      Tween fillTween = _progressImage.DOFillAmount(1, duration)
        .SetEase(FillTweenEase).Play();
      return fillTween.ToUniTask();
    }

    public void AnimateLastPartOrHideSkinObjects(bool isAllSkinsUnlockedAfterSave, float duration,
      UnlockableSkinConfig nextSkinConfigAfterSave)
    {
      if (!isAllSkinsUnlockedAfterSave)
      {
        SetSkinIconAndFillAmount(nextSkinConfigAfterSave.Icon, 0);
        _progressImage.DOFillAmount(_progress.ForSkins.NextSkinProgress, duration)
          .SetEase(FillTweenEase).Play();
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