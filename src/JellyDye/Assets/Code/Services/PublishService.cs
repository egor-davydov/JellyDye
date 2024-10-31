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
    private const string YandexHost = "app-257958.games.s3.yandex.net";

    private static Action<bool> _isCanReviewResponse;
    private static Action<bool> _onReviewPlayerAction;
    private static Action _onRewarded;
    private static Action _onSdkInitialize;
    private static Action _onPlayerInitialize;
    private static bool _gameWasMuted;

    private static AudioService _audioService;
    private readonly StaticDataService _staticDataService;

    private readonly bool _isOnCrazyGames = CrazySDK.IsAvailable && Application.platform != RuntimePlatform.WindowsPlayer;

    private Uri Uri
    {
      get
      {
        string absoluteURL = Application.absoluteURL;
        return string.IsNullOrEmpty(absoluteURL)
          ? default
          : new Uri(absoluteURL);
      }
    }

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

    public void Initialize(Action onSdkInitialize, Action onPlayerInitialize)
    {
      _onSdkInitialize = onSdkInitialize;
      _onPlayerInitialize = onPlayerInitialize;
      if (IsOnYandexGames())
      {
        InitializeYandexGames(OnSdkInitialized, PlayerInitialized);
      }
      else
      {
        if (_isOnCrazyGames)
          CrazySDK.Init(_onPlayerInitialize);
        else
          _onPlayerInitialize.Invoke();
      }
    }

    public bool IsPlatformMobile()
    {
      if (!IsOnYandexGames())
        return false;

      return IsMobile();
    }

    public bool IsOnYandexGames() =>
      Uri != null && Uri.Host == YandexHost;

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
      _gameWasMuted = _audioService.IsAudioMuted;
      if (!IsOnYandexGames())
      {
        if (_isOnCrazyGames)
          CrazySDK.Ad.RequestAd(CrazyAdType.Midgame, OnFullscreenAdvOpen, (error) => { OnFullscreenAdvClose(false); }, () => { OnFullscreenAdvClose(true); });
        return;
      }

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
          CrazySDK.Ad.RequestAd(CrazyAdType.Rewarded, () => { }, (error) => { }, GiveReward);
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