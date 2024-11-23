using Code.Data;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Skins
{
  public class EquipSkinButton : MonoBehaviour
  {
    [field: SerializeField] public SkinType SkinType { get; private set; }
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private LockSkin _lockSkin;
    [SerializeField] private Image _skinButtonImage;
    [SerializeField] private Sprite _skinEquippedSprite;
    [SerializeField] private Button _equipSkinButton;
    [SerializeField] private float _unScaleDuration;

    private Sprite _skinUnequippedSprite;
    private Tween _unScaleTween;

    private ProgressService _progress;
    private ISaveLoadService _saveLoadService;

    [Inject]
    public void Construct(ProgressService progressService, ISaveLoadService saveLoadService)
    {
      _saveLoadService = saveLoadService;
      _progress = progressService;
    }

    private void Awake()
    {
      _skinUnequippedSprite = _skinButtonImage.sprite;
      CheckIsEquipped();

      _equipSkinButton.onClick.AddListener(EquipSkin);
      _progress.ForSkins.Changed += CheckIsEquipped;
    }

    private void OnDestroy()
    {
      _unScaleTween.Kill();
      _progress.ForSkins.Changed -= CheckIsEquipped;
    }

    private void EquipSkin()
    {
      SkinData skinsProgress = _progress.ForSkins;
      if (_lockSkin.SkinLocked || skinsProgress.EquippedSkin == SkinType)
        return;

      _uiAudio.PlayClick();
      skinsProgress.EquipSkin(SkinType);
      _saveLoadService.SaveProgress();
      _skinButtonImage.sprite = _skinEquippedSprite;
      _skinButtonImage.transform.localScale = Vector3.one * 1.1f;
      _unScaleTween = _skinButtonImage.transform.DOScale(Vector3.one, _unScaleDuration);
    }

    private void CheckIsEquipped()
    {
      _skinButtonImage.sprite = SkinType == _progress.ForSkins.EquippedSkin
        ? _skinEquippedSprite
        : _skinUnequippedSprite;
    }
  }
}