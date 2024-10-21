using System;
using Code.Gameplay.Language;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.Factories.UI;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using Zenject;
using static UnityEngine.UI.Button;

namespace Code.Gameplay.UI.NewSkin
{
  public class NewSkinHud : MonoBehaviour
  {
    [SerializeField] private Transform _uiParent;
    [SerializeField] private TextMeshProUGUI _skinNameText;

    private AnimatedButtonFactory _animatedButtonFactory;
    private EquipNewSkinButtonFactory _equipNewSkinButtonFactory;
    private StaticDataService _staticDataService;
    private PublishService _publishService;

    [Inject]
    public void Construct(AnimatedButtonFactory animatedButtonFactory, EquipNewSkinButtonFactory equipNewSkinButtonFactory,
      StaticDataService staticDataService, PublishService publishService)
    {
      _publishService = publishService;
      _staticDataService = staticDataService;
      _equipNewSkinButtonFactory = equipNewSkinButtonFactory;
      _animatedButtonFactory = animatedButtonFactory;
    }

    public ButtonClickedEvent CloseSkinButtonClick { get; private set; }

    public async UniTask InitializeAsync(SkinType skinType, float delayBeforeCloseButtonCreation)
    {
      string upper = _publishService.GetPlayerLanguage() switch
      {
        LanguageType.English => skinType.ToString().ToUpper(),
        LanguageType.Russian => _staticDataService.ForSkins().GetSkinByType(skinType).RuName,
        _ => throw new ArgumentOutOfRangeException()
      };

      _skinNameText.text = upper;

      EquipNewSkinButton equipNewSkinButton = await _equipNewSkinButtonFactory.Create(_uiParent);
      equipNewSkinButton.Initialize(skinType);

      await UniTask.WaitForSeconds(delayBeforeCloseButtonCreation);

      CloseSkinButtonClick = (await _animatedButtonFactory.CreateCloseSkinButton(_uiParent)).Button.onClick;
    }
  }
}