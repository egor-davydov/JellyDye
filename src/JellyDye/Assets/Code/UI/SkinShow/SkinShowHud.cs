using System;
using Code.Enums;
using Code.Services;
using Code.Services.Factories.UI;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using Zenject;
using static UnityEngine.UI.Button;

namespace Code.UI.SkinShow
{
  public class SkinShowHud : MonoBehaviour
  {
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Transform _uiParent;
    [SerializeField] private TextMeshProUGUI _skinNameText;
    [SerializeField] private GameObject _unlockedObject;
    [SerializeField] private PurchaseShownSkinButton _purchaseShownSkinButton;

    private AnimatedButtonFactory _animatedButtonFactory;
    private EquipShownSkinButtonFactory _equipShownSkinButtonFactory;
    private StaticDataService _staticData;
    private PublishService _publishService;

    [Inject]
    public void Construct(AnimatedButtonFactory animatedButtonFactory, EquipShownSkinButtonFactory equipShownSkinButtonFactory,
      StaticDataService staticDataService, PublishService publishService)
    {
      _publishService = publishService;
      _staticData = staticDataService;
      _equipShownSkinButtonFactory = equipShownSkinButtonFactory;
      _animatedButtonFactory = animatedButtonFactory;
    }

    private SkinShowSceneConfig SkinShowSceneConfig => _staticData.ForSkins.SkinShowSceneConfig;
    public ButtonClickedEvent CloseSkinButtonClick { get; private set; }

    public async UniTask InitializeUnlockedSkinHudAsync(SkinType skinType)
    {
      InitSkinName(skinType);

      EquipShownSkinButton equipShownSkinButton = await _equipShownSkinButtonFactory.Create(_uiParent).AttachExternalCancellation(destroyCancellationToken);
      equipShownSkinButton.Initialize(skinType);

      await UniTask.WaitForSeconds(SkinShowSceneConfig.DelayBeforeCloseButtonCreation).AttachExternalCancellation(destroyCancellationToken);

      CloseSkinButtonClick = (await _animatedButtonFactory.CreateCloseSkinButton(_uiParent).AttachExternalCancellation(destroyCancellationToken)).Button.onClick;
    }
    
    public async UniTask InitializePurchasableSkinHudAsync(SkinType skinType)
    {
      InitSkinName(skinType);
      _unlockedObject.SetActive(false);
      _purchaseShownSkinButton.gameObject.SetActive(true);
      
      _purchaseShownSkinButton.Initialize(skinType, OnPurchaseSuccess);
      
      CloseSkinButtonClick = (await _animatedButtonFactory.CreateCloseSkinButton(_uiParent, animate: false)
        .AttachExternalCancellation(destroyCancellationToken)).Button.onClick;
    }

    private void OnPurchaseSuccess()
    {
      _unlockedObject.SetActive(true);
      _audioSource.PlayOneShot(SkinShowSceneConfig.NewSkinSound);
    }
    private void InitSkinName(SkinType skinType)
    {
      string localizedSkinName = _publishService.GetPlayerLanguage() switch
      {
        LanguageType.English => skinType.ToString(),
        LanguageType.Russian => _staticData.ForSkin(skinType).RuName,
        _ => throw new ArgumentOutOfRangeException()
      };

      _skinNameText.text = localizedSkinName.ToUpper();
    }
  }
}