using System;
using AOT;
using Code.Gameplay.Logic;
#if !UNITY_EDITOR && UNITY_WEBGL
using System.Runtime.InteropServices;
using Code.StaticServices;
#endif

namespace Code.Services
{
  public class YandexService
  {
      private static Action<bool> _isCanReviewResponse;
      private static Action<bool> _onPlayerAction;

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
#endif

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
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
          ShowFullscreenAdv(FullscreenAdvStaticService.OnOpen, FullscreenAdvStaticService.OnClose);

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

#if !UNITY_EDITOR && UNITY_WEBGL
    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void ServerIsCanReviewResponse(bool value) => 
        _isCanReviewResponse.Invoke(value);
    
    [MonoPInvokeCallback(typeof(Action<bool>))]
    private static void ServerReviewWindowActionResponse(bool value) => 
        _onPlayerAction.Invoke(value);
#endif
  }
}