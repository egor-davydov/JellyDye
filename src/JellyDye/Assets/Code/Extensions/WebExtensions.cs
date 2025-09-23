using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Code.Extensions
{
  public static class WebExtensions
  {
    public static async UniTask<Texture2D> GetTextureFromUrlAsync(this string imageAddress)
    {
      using UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(imageAddress);
      await uwr.SendWebRequest();

      if (uwr.result != UnityWebRequest.Result.Success)
      {
        Debug.LogError($"Ошибка загрузки: {uwr.error}, URL: {imageAddress}");
        Debug.LogError($"Response Code: {uwr.responseCode}");
        Debug.LogError($"Text: {uwr.downloadHandler?.text}");
        throw new Exception($"Ошибка загрузки текстуры: {uwr.error} ({imageAddress})");
      }
      
      return DownloadHandlerTexture.GetContent(uwr);
    }
  }
}