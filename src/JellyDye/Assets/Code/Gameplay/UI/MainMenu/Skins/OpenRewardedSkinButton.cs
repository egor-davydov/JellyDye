using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Skins
{
  public class OpenRewardedSkinButton : MonoBehaviour
  {
    [SerializeField] private Button _openButton;
    [SerializeField] private EquipSkinButton _equipSkinButton;
    [SerializeField] private LockSkin _lockSkin;

    private ProgressService _progressService;
    private ISaveLoadService _saveLoadService;
    private PublishService _publishService;
    
    [Inject]
    public void Construct(ProgressService progressService, ISaveLoadService saveLoadService, PublishService publishService)
    {
      _publishService = publishService;
      _saveLoadService = saveLoadService;
      _progressService = progressService;
    }

    private void Awake()
    {
      _openButton.onClick.AddListener(ShowRewardedVideoClick);
    }
    
    private void ShowRewardedVideoClick()
    {
      _publishService.ShowRewardedVideo(OpenRewardedSkin);
    }

    private void OpenRewardedSkin()
    {
      _progressService.Progress.SkinData.OpenedSkins.Add(_equipSkinButton.SkinType);
      _saveLoadService.SaveProgress();
      _lockSkin.UnlockSkin();
    }
  }
}