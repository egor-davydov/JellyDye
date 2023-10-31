using System;
using Code.Gameplay.Logic;
using CrazyGames;
#if !UNITY_EDITOR && UNITY_WEBGL
using UnityEngine;
using AOT;
using System.Runtime.InteropServices;
#endif

namespace Code.Services
{
  public class PublishService
  {
    private static AudioService _audioService;
    private static Action<bool> _isCanReviewResponse;
    private static Action<bool> _onPlayerAction;
    private static Action _onRewarded;
    private readonly bool _isOnCrazyGames = CrazySDK.IsOnCrazyGames;

    public event Action OnSdkInitilized;
    public bool SdkInitialized { get; private set; }

    public PublishService(AudioService audioService) => 
      _audioService = audioService;
    
#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern bool IsYandexGames();

    [DllImport("__Internal")]
    private static extern string GetYandexLanguage();

    [DllImport("__Internal")]
    private static extern void GameReadyToPLayYandex();

    [DllImport("__Internal")]
    private static extern void ShowYandexFullscreenAdv(Action onOpen = null, Action onClose = null);
    
    [DllImport("__Internal")]
    private static extern void SetToYandexLeaderboard(int score);
    
    [DllImport("__Internal")]
    private static extern void RequestYandexIsPlayerCanReview(Action<bool> response);

    [DllImport("__Internal")]
    private static extern void ShowYandexReviewGameWindow(Action<bool> onPlayerAction);

    [DllImport("__Internal")]
    private static extern void ShowYandexRewardedVideo(Action onRewarded);
#endif

    public void InvokeSdkInitEvent()
    {
      OnSdkInitilized?.Invoke();
      SdkInitialized = true;
    }

    public void SetToLeaderboard(int score)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        SetToYandexLeaderboard(score);
#endif
    }

    public LanguageType GetPlayerLanguage()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
      {
          string yandexLanguage = GetYandexLanguage();
          return yandexLanguage switch
          {
              "en" => LanguageType.English,
              "ru" => LanguageType.Russian,
              _ => throw new ArgumentOutOfRangeException($"Unsupported language '{yandexLanguage}'")
          };
      }
#endif
      return LanguageType.English;
    }

    public void ShowFullscreenAdvAndPauseGame()
    {
      if(_isOnCrazyGames)
        CrazyAds.Instance.beginAdBreak();
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
          ShowFullscreenAdv(onOpen: OnFullscreenAdvOpen, onClose: OnFullscreenAdvClose);
#endif
    }

    public void ShowFullscreenAdv(Action onOpen = null, Action onClose = null)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        ShowYandexFullscreenAdv(onOpen, onClose);
#endif
    }

    public void GameReadyToPLay()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        GameReadyToPLayYandex();
#endif
    }

    public void RequestCanPLayerReviewOrNot(Action<bool> isCanReviewResponse)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (!IsYandexGames())
        return; 
      
      _isCanReviewResponse = isCanReviewResponse;
      RequestYandexIsPlayerCanReview(ServerIsCanReviewResponse);
#endif
    }

    public void ShowReviewGameWindow(Action<bool> onPlayerAction)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (!IsYandexGames())
        return; 
      
      _onPlayerAction = onPlayerAction;
      ShowYandexReviewGameWindow(ServerReviewWindowActionResponse);
#endif
    }

    public void ShowRewardedVideo(Action onRewarded)
    {
      _onRewarded = onRewarded;
      if(_isOnCrazyGames)
        CrazyAds.Instance.beginAdBreakRewarded(GiveReward);
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        ShowYandexRewardedVideo(OnRewardedVideoEnd);
      else
        GiveReward();
#else
      GiveReward();
#endif
    }

    private void GiveReward() =>
      _onRewarded?.Invoke();

#if !UNITY_EDITOR && UNITY_WEBGL
    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoEnd() =>
      _onRewarded?.Invoke();

    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void ServerIsCanReviewResponse(bool value) => 
      _isCanReviewResponse.Invoke(value);
    
    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void ServerReviewWindowActionResponse(bool value) => 
      _onPlayerAction.Invoke(value);

    [MonoPInvokeCallback(typeof(Action))]
    public static void OnFullscreenAdvOpen()
    {
      _audioService.MuteGame();
      //Time.timeScale = 0;
    }

    [MonoPInvokeCallback(typeof(Action))]
    public static void OnFullscreenAdvClose()
    {
      _audioService.UnMuteGame();
      //Time.timeScale = 1;
    }
#endif
  }
}