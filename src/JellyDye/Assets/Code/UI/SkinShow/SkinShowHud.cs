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
    [SerializeField] private Transform _uiParent;
    [SerializeField] private TextMeshProUGUI _skinNameText;

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

    public async UniTask InitializeAsync(SkinType skinType)
    {
      string localizedSkinName = _publishService.GetPlayerLanguage() switch
      {
        LanguageType.English => skinType.ToString(),
        LanguageType.Russian => _staticData.ForSkin(skinType).RuName,
        _ => throw new ArgumentOutOfRangeException()
      };

      _skinNameText.text = localizedSkinName.ToUpper();

      EquipShownSkinButton equipShownSkinButton = await _equipShownSkinButtonFactory.Create(_uiParent).AttachExternalCancellation(destroyCancellationToken);
      equipShownSkinButton.Initialize(skinType);

      await UniTask.WaitForSeconds(SkinShowSceneConfig.DelayBeforeCloseButtonCreation).AttachExternalCancellation(destroyCancellationToken);

      CloseSkinButtonClick = (await _animatedButtonFactory.CreateCloseSkinButton(_uiParent).AttachExternalCancellation(destroyCancellationToken)).Button.onClick;
    }
  }
}