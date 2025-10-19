using System;
using Code.Enums;
using Code.InAppPurchases;
using Code.Services;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.SkinShow
{
  public class PurchaseShownSkinButton : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private RawImage _currencyRawImage;
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _button;

    private PublishService _publishService;
    private EquipShownSkinButtonFactory _equipShownSkinButtonFactory;

    private SkinType _skinType;
    private CatalogProduct _product;
    private Action _onSuccess;
    private ProgressService _progress;
    private ISaveLoadService _saveLoadService;

    [Inject]
    public void Construct(PublishService publishService, ProgressService progress,
      ISaveLoadService saveLoadService, EquipShownSkinButtonFactory equipShownSkinButtonFactory)
    {
      _saveLoadService = saveLoadService;
      _progress = progress;
      _publishService = publishService;
      _equipShownSkinButtonFactory = equipShownSkinButtonFactory;
    }

    public void Initialize(SkinType skinType, Action onSuccess)
    {
      _onSuccess = onSuccess;
      _skinType = skinType;
      _product = _publishService.GetSkinProduct(skinType);

      _currencyRawImage.texture = _publishService.CurrencyTexture;
#if !UNITY_EDITOR
      _priceText.text = _product.PriceValue;
#endif
    }

    private void Awake()
    {
      _button.onClick.AddListener(OnPurchaseShownSkinButtonClick);
    }

    private void OnPurchaseShownSkinButtonClick()
    {
      _uiAudio.PlayClick();
      _publishService.PurchaseProduct(_product.Id, UniTask.Action(OnPurchaseSuccess));
    }

    private async UniTaskVoid OnPurchaseSuccess()
    {
      _progress.ForSkins.OpenSkin(_skinType);
      _saveLoadService.SaveProgress();

      _onSuccess?.Invoke();
      EquipShownSkinButton equipShownSkinButton = await _equipShownSkinButtonFactory.Create(transform.parent);
      equipShownSkinButton.Initialize(_skinType);
      Destroy(gameObject);
    }
  }
}