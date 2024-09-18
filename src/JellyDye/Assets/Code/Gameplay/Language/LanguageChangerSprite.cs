using System;
using Code.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Language
{
  public class LanguageChangerSprite : MonoBehaviour
  {
    [SerializeField] private Sprite _enSprite;
    [SerializeField] private Sprite _ruSprite;
    [SerializeField] private Image _image;
    
    private PublishService _publishService;

    [Inject]
    public void Construct(PublishService publishService)
    {
      _publishService = publishService;
      
      ChangeLanguage();
    }

    private void ChangeLanguage()
    {
      LanguageType playerLanguage = _publishService.GetPlayerLanguage();
      _image.sprite = playerLanguage switch
      {
        LanguageType.English => _enSprite,
        LanguageType.Russian => _ruSprite,
        _ => throw new ArgumentOutOfRangeException()
      };
    }
  }
}