#if !UNITY_EDITOR && UNITY_WEBGL
using UnityEngine;
#endif
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Code.Enums;
using Code.Extensions;
using Code.InAppPurchases;
using Code.Logging;
using CrazyGames;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using ModestTree;
using UnityEngine;
using UnityEngine.Networking;

namespace Code.Services
{
  public class PublishService
  {
    private const string YandexHost = "app-257958.games.s3.yandex.net";

    private static Action<bool> _isCanReviewResponse;
    private static Action<bool> _onReviewPlayerAction;
    private static Action _onRewarded;
    private static Action _onRewardedClose;
    private static Action _onSdkInitialize;
    private static Action _onPlayerInitialize;
    private static bool _gameWasMuted;

    private static AudioService _audioService;
    private readonly StaticDataService _staticData;

    private readonly bool _isOnCrazyGames = CrazySDK.IsAvailable && Application.platform != RuntimePlatform.WindowsPlayer;
    private static UniTaskCompletionSource _playerInitTcs;
    private static Action<string> _onGetProductCatalogSuccess;
    private static Action<string> _onGetPurchasedSuccess;
    private static Action _onPurchaseSuccess;

    public PublishService(AudioService audioService, StaticDataService staticData)
    {
      _staticData = staticData;
      _audioService = audioService;
    }

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

    public Texture2D CurrencyTexture { get; private set; }
    public CatalogProduct[] ProductCatalog { get; private set; }

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
    private static extern void ShowYandexRewardedVideo(Action onOpen, Action onRewarded, Action onClose);

    [DllImport("__Internal")]
    private static extern void BillingPurchaseProduct(string productId, Action<string> onSuccess);

    [DllImport("__Internal")]
    private static extern void BillingGetProductCatalog(Action<string> onSuccess);

    [DllImport("__Internal")]
    private static extern void BillingGetPurchasedProducts(Action<string> onSuccess);

    [CanBeNull]
    public CatalogProduct GetSkinProduct(SkinType skinType) =>
      GetCatalogProduct(SkinTypeToProductId(skinType));

    public string SkinTypeToProductId(SkinType skinType) =>
      skinType.ToString();

    public SkinType ProductIdToSkinType(string productId)
    {
      if (Enum.TryParse(productId, out SkinType skinType))
        return skinType;

      throw new ArgumentException($"Неизвестный productId: {productId}");
    }

    [CanBeNull]
    public CatalogProduct GetCatalogProduct(string productId) =>
      ProductCatalog?.FirstOrDefault(x => x.Id == productId);

    public void PurchaseProduct(string productId, Action onSuccess)
    {
      _onPurchaseSuccess = onSuccess;
      BillingPurchaseProduct(productId, OnPurchaseSuccess);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnPurchaseSuccess(string purchasedProductJson) =>
      _onPurchaseSuccess?.Invoke();

    private UniTask<CatalogProduct[]> GetProductCatalog()
    {
      var tcs = new UniTaskCompletionSource<CatalogProduct[]>();
      GetProductCatalogJson(json =>
      {
        WebDebug.Log($"GetProductCatalogJson json: {json}");
        var response = JsonUtility.FromJson<GetProductCatalogResponse>(json);
        foreach (CatalogProduct responseProduct in response.Products)
        {
          WebDebug.Log($"GetProductCatalogJson response:" +
                       $" Id={responseProduct.Id};" +
                       $" PriceValue={responseProduct.PriceValue};" +
                       $" PriceCurrencyImage={responseProduct.PriceCurrencyImage}");
        }
        tcs.TrySetResult(response.Products);
      });

      return tcs.Task;
    }

    public UniTask<PurchasedProduct[]> GetPurchases()
    {
      var tcs = new UniTaskCompletionSource<PurchasedProduct[]>();
      GetPurchasesJson(json =>
      {
        var response = JsonUtility.FromJson<GetPurchasedProductsResponse>(json);
        tcs.TrySetResult(response.PurchasedProducts);
      });

      return tcs.Task;
    }

    private void GetProductCatalogJson(Action<string> onSuccess)
    {
      _onGetProductCatalogSuccess = onSuccess;
      BillingGetProductCatalog(OnGetProductCatalogSuccess);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnGetProductCatalogSuccess(string resultJson) =>
      _onGetProductCatalogSuccess?.Invoke(resultJson);

    private void GetPurchasesJson(Action<string> onSuccess)
    {
      _onGetPurchasedSuccess = onSuccess;
      BillingGetPurchasedProducts(OnGetPurchasesSuccess);
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnGetPurchasesSuccess(string resultJson) =>
      _onGetPurchasedSuccess?.Invoke(resultJson);

    public async UniTask Initialize()
    {
      _playerInitTcs = new UniTaskCompletionSource();
      if (IsOnYandexGames())
      {
        InitializeYandexGames(
          OnSdkInitialized,
          OnPlayerInitialize
        );

        await _playerInitTcs.Task;
        await InitYandexInApps();
      }
      else
      {
        if (_isOnCrazyGames)
          CrazySDK.Init(() => { _playerInitTcs.TrySetResult(); });
        await _playerInitTcs.Task;
      }
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnSdkInitialized() =>
      _onSdkInitialize?.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnPlayerInitialize() => 
      _playerInitTcs?.TrySetResult();

    private async UniTask InitYandexInApps()
    {
      WebDebug.Log("InitYandexInApps");
      ProductCatalog = await GetProductCatalog();
      WebDebug.Log("After GetProductCatalog");
      WebDebug.Log($"PriceCurrencyImage={ProductCatalog[0].PriceCurrencyImage}");
      CurrencyTexture = await ProductCatalog[0].PriceCurrencyImage.GetTextureFromUrlAsync();
      WebDebug.Log("After GetTextureFromUrlAsync");
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
        return _staticData.ForGameSettings.DefaultLanguage;

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

    public void RequestCanPlayerReviewOrNot(Action<bool> isCanReviewResponse)
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

    public void ShowRewardedVideo(Action onRewarded, Action onClose)
    {
      _onRewarded = onRewarded;
      _onRewardedClose = onClose;
      if (!IsOnYandexGames())
      {
        if (_isOnCrazyGames)
          CrazySDK.Ad.RequestAd(CrazyAdType.Rewarded, () => { }, (error) => { }, GiveReward);
        else
          GiveReward();
        return;
      }

      ShowYandexRewardedVideo(OnRewardedVideoOpen, OnRewardedVideoEnd, OnRewardedVideoClose);
    }

    private void GiveReward()
    {
      _onRewarded?.Invoke();
      _onRewardedClose?.Invoke();
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoOpen()
    {
      _audioService.MuteGame();
      Time.timeScale = 0;
    }

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoEnd() =>
      _onRewarded?.Invoke();

    [MonoPInvokeCallback(typeof(Action))]
    private static void OnRewardedVideoClose()
    {
      _audioService.UnMuteGame();
      Time.timeScale = 1;
      _onRewardedClose?.Invoke();
    }

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