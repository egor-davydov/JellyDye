using Code.Data;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Skins
{
  public class EquipSkinButton : MonoBehaviour
  {
    [field: SerializeField] public SkinType SkinType { get; private set; }
    [SerializeField] private LockSkin _lockSkin;
    [SerializeField] private Image _skinButtonImage;
    [SerializeField] private Sprite _skinEquippedSprite;
    [SerializeField] private Button _equipSkinButton;
    
    private Sprite _skinUnequippedSprite;

    private ProgressService _progressService;
    private SkinData _progressSkinData;
    private ISaveLoadService _saveLoadService;
    

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

    private void OnDestroy() => 
      _progressSkinData.Changed -= CheckEquipped;

    private void EquipSkin()
    {
      if (_lockSkin.SkinLocked || _progressSkinData.EquippedSkin == SkinType)
        return;

      _progressSkinData.EquipSkin(SkinType);
      _skinButtonImage.sprite = _skinEquippedSprite;
      _saveLoadService.SaveProgress();
    }

    private void CheckEquipped()
    {
      _skinButtonImage.sprite = SkinType == _progressSkinData.EquippedSkin
        ? _skinEquippedSprite
        : _skinUnequippedSprite;
    }
  }
}