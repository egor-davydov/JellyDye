using Code.Data;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
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

    private ProgressService _progressService;
    private SkinData _progressSkinData;
    private ISaveLoadService _saveLoadService;
    private Tween _unScaleTween;
    
    [Inject]
    public void Construct(ProgressService progressService, ISaveLoadService saveLoadService)
    {
      _saveLoadService = saveLoadService;
      _progressService = progressService;
      _progressSkinData = _progressService.Progress.SkinData;
    }

    private void Awake()
    {
      _skinUnequippedSprite = _skinButtonImage.sprite;
      CheckEquipped();

      _equipSkinButton.onClick.AddListener(EquipSkin);
      _progressSkinData.Changed += CheckEquipped;
    }

    private void OnDestroy()
    {
      _unScaleTween.Kill();
      _progressSkinData.Changed -= CheckEquipped;
    }

    private void EquipSkin()
    {
      if (_lockSkin.SkinLocked || _progressSkinData.EquippedSkin == SkinType)
        return;

      _uiAudio.PlayClick();
      _progressSkinData.EquipSkin(SkinType);
      _saveLoadService.SaveProgress();
      _skinButtonImage.sprite = _skinEquippedSprite;
      _skinButtonImage.transform.localScale = Vector3.one* 1.1f;
      _unScaleTween = _skinButtonImage.transform.DOScale(Vector3.one, _unScaleDuration);
    }

    private void CheckEquipped()
    {
      _skinButtonImage.sprite = SkinType == _progressSkinData.EquippedSkin
        ? _skinEquippedSprite
        : _skinUnequippedSprite;
    }
  }
}