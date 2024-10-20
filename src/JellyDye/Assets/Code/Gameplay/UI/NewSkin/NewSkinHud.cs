using System;
using Code.Gameplay.UI.MainMenu.Skins;
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
    [SerializeField] private Transform _closeButtonParent;
    [SerializeField] private TextMeshProUGUI _skinNameText;

    private AnimatedButtonFactory _animatedButtonFactory;

    [Inject]
    public void Construct(AnimatedButtonFactory animatedButtonFactory)
    {
      _animatedButtonFactory = animatedButtonFactory;
    }

    public ButtonClickedEvent CloseSkinButtonClick { get; private set; }

    public async UniTask InitializeAsync(SkinType skinType, float delayBeforeCloseButtonCreation)
    {
      _skinNameText.text = skinType.ToString().ToUpper();
      await UniTask.Delay(TimeSpan.FromSeconds(delayBeforeCloseButtonCreation));
      CloseSkinButtonClick = (await _animatedButtonFactory.CreateCloseSkinButton(_closeButtonParent)).GetComponent<CloseSkinButton>().Button.onClick;
    }
  }
}