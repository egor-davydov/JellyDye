using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.MainMenuWindow.Skins
{
  public class OpenRewardedSkinButton : MonoBehaviour
  {
    [SerializeField] private Button _openButton;
    [SerializeField] private EquipSkinButton _equipSkinButton;
    [SerializeField] private LockSkin _lockSkin;

    private ProgressService _progress;
    private ISaveLoadService _saveLoadService;
    private PublishService _publishService;
    private SkinShowSceneService _skinShowSceneService;

    [Inject]
    public void Construct(ProgressService progressService, ISaveLoadService saveLoadService, PublishService publishService,
      SkinShowSceneService skinShowSceneService)
    {
      _skinShowSceneService = skinShowSceneService;
      _publishService = publishService;
      _saveLoadService = saveLoadService;
      _progress = progressService;
    }

    private void Awake()
    {
      _openButton.onClick.AddListener(ShowRewardedVideoClick);
    }

    private void ShowRewardedVideoClick()
    {
      _openButton.interactable = false;
      _publishService.ShowRewardedVideo(OpenRewardedSkin, UniTask.Action(ShowRewardedSkin));
    }

    private void OpenRewardedSkin()
    {
      _progress.ForSkins.OpenSkin(_equipSkinButton.SkinType);
      _saveLoadService.SaveProgress();
    }

    private async UniTaskVoid ShowRewardedSkin()
    {
      await _skinShowSceneService.ShowSkinScene(_equipSkinButton.SkinType);
      _lockSkin.UnlockSkin();
    }
  }
}