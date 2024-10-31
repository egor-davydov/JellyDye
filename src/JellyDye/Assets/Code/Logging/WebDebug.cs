using System.Runtime.InteropServices;
using UnityEngine;

namespace Code.Logging
{
  public static class WebDebug
  {
    [DllImport("__Internal")]
    private static extern void WebDebugLog(string log);

    public static void Log(string log)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
      WebDebugLog(log);
#else
      Debug.Log(log);
#endif
    }
  }
}