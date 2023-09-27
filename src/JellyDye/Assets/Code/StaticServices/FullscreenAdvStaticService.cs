#if !UNITY_EDITOR && UNITY_WEBGL
using System;
using AOT;
using UnityEngine;

namespace Code.StaticServices
{
  public class FullscreenAdvStaticService
  {
    [MonoPInvokeCallback(typeof(Action))]
    public static void OnOpen()
    {
      Time.timeScale = 0;
    }
    [MonoPInvokeCallback(typeof(Action))]
    public static void OnClose()
    {
      Time.timeScale = 1;
    }
  }
}
#endif