#if !UNITY_EDITOR && UNITY_WEBGL
using UnityEngine;
#endif
using System;
using System.Runtime.InteropServices;
using AOT;
using Code.Gameplay.Language;
using CrazyGames;
using UnityEngine;

namespace Code.Services
{
  public class PublishService
  {
    private static AudioService _audioService;
    private static Action<bool> _isCanReviewResponse;
    private static Action<bool> _onReviewPlayerAction;
    private static Action _onRewarded;
    private static Action _onSdkInitialize;
    private static Action _onPlayerInitialize;
    private static bool _gameWasMuted;

    private readonly bool _isOnCrazyGames = CrazySDK.IsOnCrazyGames && Application.platform != RuntimePlatform.WindowsPlayer;
    private StaticDataService _staticDataService;
#if !UNITY_EDITOR && UNITY_WEBGL
    private readonly Uri _uri = new (Application.absoluteURL);
    private readonly string _yandexDomain = CrazySDK.Instance.GetSettings().whitelistedDomains[0];
#endif

    public PublishService(AudioService audioService, StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
      _audioService = audioService;
    }

    [DllImport("__Internal")]
    private static extern bool IsMobile();

    [DllImport("__Internal")]
    private static extern void InitializeYandexGames(Action onSdkInitialize, Action onPlayerInitialize);

    [DllImport("__Internal")]
    private static extern string GetYandexLanguage();

    [DllImport("__Internal")]
    private static extern void GameReadyToPlayYandex();

    [DllImport("__Internal")]
    private static extern void ShowYandexFullscreenAdv(Action onOpen = null, Action<bool> onClose = null);

    [DllImport("__Internal")]
    private static extern void SetToYandexLeaderboard(int score);

    [DllImport("__Internal")]
    private static extern void RequestYandexIsPlayerCanReview(Action<bool> response);

    [DllImport("__Internal")]
    private static extern void ShowYandexReviewGameWindow(Action<bool> onPlayerAction);

    [DllImport("__Internal")]
    private static extern void ShowYandexRewardedVideo(Action onRewarded);

    public bool IsPlatformMobile()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      return IsMobile();
#else
      return false;
#endif
    }
    
    public bool IsOnYandexGames()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      return _uri.Host == _yandexDomain;
#else
      return false;
#endif
    }

    public void InvokeOnSdkInitialize() =>
      OnSdkInitialized();

    public void InitializeYandex(Action onSdkInitialize, Action onPlayerInitialize)
    {
      _onSdkInitialize = onSdkInitialize;
      _onPlayerInitialize = onPlayerInitialize;
      InitializeYandexGames(OnSdkInitialized, PlayerInitialized);
    }

    public void SetToLeaderboard(int score)
    {
      if (!IsOnYandexGames())
        return;

      SetToYandexLeaderboard(score);
    }

    public LanguageType GetPlayerLanguage()
    {
      if (!IsOnYandexGames())
        return _staticDataService.ForGameSettings().DefaultLanguage;

      string yandexLanguage = GetYandexLanguage();
      return yandexLanguage switch
      {
        "en" => LanguageType.English,
        "ru" => LanguageType.Russian,
        _ =>
          LanguageType.English
          //throw new ArgumentOutOfRangeException($"Unsupported language '{yandexLanguage}'")
      };
    }

    public void ShowFullscreenAdvAndPauseGame()
    {
      if (!IsOnYandexGames())
      {
        if (_isOnCrazyGames)
          if (CrazyAds.Instance != null)
            CrazyAds.Instance.beginAdBreak();
        return;
      }

      _gameWasMuted = _audioService.IsAudioMuted;

      ShowYandexFullscreenAdv(onOpen: OnFullscreenAdvOpen, onClose: OnFullscreenAdvClose);
    }

    public void GameReadyToPlay()
    {
      if (IsOnYandexGames())
        GameReadyToPlayYandex();
    }

    public void RequestCanPLayerReviewOrNot(Action<bool> isCanReviewResponse)
    {
      if (!IsOnYandexGames())
        return;

      _isCanReviewResponse = isCanReviewResponse;
      RequestYandexIsPlayerCanReview(ServerIsCanReviewResponse);
    }

    public void ShowReviewGameWindow(Action<bool> onPlayerAction)
    {
      if (!IsOnYandexGames())
        return;

      _onReviewPlayerAction = onPlayerAction;
      ShowYandexReviewGameWindow(ServerReviewWindowActionResponse);
    }

    public void ShowRewardedVideo(Action onRewarded)
    {
      _onRewarded = onRewarded;
      if (!IsOnYandexGames())
      {
        if (_isOnCrazyGames)
          CrazyAds.Instance.beginAdBreakRewarded(GiveReward);
        else
          GiveReward();
        return;
      }

      ShowYandexRewardedVideo(OnRewardedVideoEnd);
    }

    private void GiveReward() =>
      _onRewarded?.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnSdkInitialized() => 
      _onSdkInitialize?.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void PlayerInitialized() =>
      _onPlayerInitialize.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoEnd() =>
      _onRewarded?.Invoke();

    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void ServerIsCanReviewResponse(bool value) =>
      _isCanReviewResponse.Invoke(value);

    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void ServerReviewWindowActionResponse(bool value) =>
      _onReviewPlayerAction.Invoke(value);

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnFullscreenAdvOpen()
    {
      if (!_gameWasMuted)
        _audioService.MuteGame();
    }

    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void OnFullscreenAdvClose(bool wasShown)
    {
      if (!_gameWasMuted)
        _audioService.UnMuteGame();
    }
  }
}