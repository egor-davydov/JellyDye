using Code.Enums;
using Code.InAppPurchases;
using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI.MainMenuWindow.Skins
{
  public class OpenPurchasableSkinButton : MonoBehaviour
  {
    [SerializeField] private Button _openButton;
    [SerializeField] private EquipSkinButton _equipSkinButton;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private RawImage _currencyRawImage;

    private PublishService _publishService;
    private SkinShowSceneService _skinShowSceneService;

    [Inject]
    public void Construct(PublishService publishService, SkinShowSceneService skinShowSceneService)
    {
      _skinShowSceneService = skinShowSceneService;
      _publishService = publishService;
    }

    private SkinType SkinType => _equipSkinButton.SkinType;

    private void Awake()
    {
      _openButton.onClick.AddListener(UniTask.UnityAction(ShowSkinScene));
      _currencyRawImage.texture = _publishService.CurrencyTexture;
#if !UNITY_EDITOR
      _priceText.text = _publishService.GetSkinProduct(SkinType).PriceValue;
#endif
    }

    private async UniTaskVoid ShowSkinScene()
    {
      await _skinShowSceneService.ShowPurchasableSkinScene(SkinType);
    }
  }
}