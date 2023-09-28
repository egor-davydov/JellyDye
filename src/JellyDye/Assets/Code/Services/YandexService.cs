using System;
#if !UNITY_EDITOR && UNITY_WEBGL
using System.Runtime.InteropServices;
using Code.StaticServices;
#endif

namespace Code.Services
{
  public class YandexService
  {
#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern bool IsYandexGames();

    [DllImport("__Internal")]
    private static extern void GameReadyToPLayYandex();

    [DllImport("__Internal")]
    private static extern void ShowYandexFullscreenAdv(Action onOpen = null, Action onClose = null);
    
    [DllImport("__Internal")]
    private static extern void SetToYandexLeaderboard(int score);
#endif

    public void SetToLeaderboard(int score)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
        SetToYandexLeaderboard(score);
#endif
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
  }
}