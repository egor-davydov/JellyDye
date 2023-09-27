#if !UNITY_EDITOR && UNITY_WEBGL
using System;
using System.Runtime.InteropServices;
using Code.StaticServices;
#endif
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

#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern bool IsYandexGames();

    [DllImport("__Internal")]
    private static extern void ShowRewardedVideo(Action onRewarded);
#endif

    [Inject]
    public void Construct(ProgressService progressService, ISaveLoadService saveLoadService)
    {
      _saveLoadService = saveLoadService;
      _progressService = progressService;
    }

    private void Awake()
    {
      _openButton.onClick.AddListener(ShowRewardedVideoClick);
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        RewardedStaticService.OnRewarded += OpenRewardedSkin;
#endif
    }

    private void OnDestroy()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      RewardedStaticService.OnRewarded -= OpenRewardedSkin;
#endif
    }

    private void ShowRewardedVideoClick()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        RewardedStaticService.ShowRewarded(_equipSkinButton.SkinType);
      else
        OpenRewardedSkin(_equipSkinButton.SkinType);
#else
      OpenRewardedSkin(_equipSkinButton.SkinType);
#endif
    }

    private void OpenRewardedSkin(SkinType skinType)
    {
      if (skinType != _equipSkinButton.SkinType)
        return;
      
      _progressService.Progress.SkinData.OpenedSkins.Add(_equipSkinButton.SkinType);
      _saveLoadService.SaveProgress();
      _lockSkin.UnlockSkin();
    }
  }
}