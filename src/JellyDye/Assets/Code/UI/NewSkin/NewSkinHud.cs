﻿using System;
using Code.Enums;
using Code.Services;
using Code.Services.Factories.UI;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using Zenject;
using static UnityEngine.UI.Button;

namespace Code.UI.NewSkin
{
  public class NewSkinHud : MonoBehaviour
  {
    [SerializeField] private Transform _uiParent;
    [SerializeField] private TextMeshProUGUI _skinNameText;

    private AnimatedButtonFactory _animatedButtonFactory;
    private EquipNewSkinButtonFactory _equipNewSkinButtonFactory;
    private StaticDataService _staticData;
    private PublishService _publishService;

    [Inject]
    public void Construct(AnimatedButtonFactory animatedButtonFactory, EquipNewSkinButtonFactory equipNewSkinButtonFactory,
      StaticDataService staticDataService, PublishService publishService)
    {
      _publishService = publishService;
      _staticData = staticDataService;
      _equipNewSkinButtonFactory = equipNewSkinButtonFactory;
      _animatedButtonFactory = animatedButtonFactory;
    }

    private NewSkinSceneConfig NewSkinSceneConfig => _staticData.ForSkins.NewSkinSceneConfig;
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

      EquipNewSkinButton equipNewSkinButton = await _equipNewSkinButtonFactory.Create(_uiParent).AttachExternalCancellation(destroyCancellationToken);
      equipNewSkinButton.Initialize(skinType);

      await UniTask.WaitForSeconds(NewSkinSceneConfig.DelayBeforeCloseButtonCreation).AttachExternalCancellation(destroyCancellationToken);

      CloseSkinButtonClick = (await _animatedButtonFactory.CreateCloseSkinButton(_uiParent).AttachExternalCancellation(destroyCancellationToken)).Button.onClick;
    }
  }
}