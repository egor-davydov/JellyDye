#if !UNITY_EDITOR && UNITY_WEBGL
using Code.Gameplay.UI.MainMenu.Skins;
using System.Runtime.InteropServices;
using System;
using AOT;

namespace Code.StaticServices
{
  public class RewardedStaticService
  {
    public static Action<SkinType> OnRewarded;
    private static SkinType _skinType;
    [DllImport("__Internal")]
    private static extern bool IsYandexGames();

    [DllImport("__Internal")]
    private static extern void ShowRewardedVideo(Action onRewarded);

    public static void ShowRewarded(SkinType skinType)
    {
      _skinType = skinType;
      ShowRewardedVideo(OnRewardedVideoEnd);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoEnd()
    {
      OnRewarded?.Invoke(_skinType);
    }
  }
}
#endif
