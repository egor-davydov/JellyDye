#if !UNITY_EDITOR && UNITY_WEBGL
using Code.Gameplay.UI.MainMenu.Skins;
using System.Runtime.InteropServices;
using System;
using AOT;

namespace Code.StaticServices
{
  public class RewardedStaticService
  {
    private static SkinType _skinType;
    private static Action<SkinType> _onRewarded;

    [DllImport("__Internal")]
    private static extern void ShowRewardedVideo(Action onRewarded);

    public static void ShowRewarded(SkinType skinType, Action<SkinType> onRewarded)
    {
      _skinType = skinType;
      _onRewarded = onRewarded;
      ShowRewardedVideo(OnRewardedVideoEnd);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoEnd()
    {
      _onRewarded?.Invoke(_skinType);
    }
  }
}
#endif
