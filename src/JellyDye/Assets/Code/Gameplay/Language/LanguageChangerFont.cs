using System;
using Code.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Language
{
  public class LanguageChangerFont : MonoBehaviour
  {
    [SerializeField] private TMP_FontAsset _enFont;
    [SerializeField] private TMP_FontAsset _ruFont;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    
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
      _textMeshPro.font = playerLanguage switch
      {
        LanguageType.English => _enFont,
        LanguageType.Russian => _ruFont,
        _ => throw new ArgumentOutOfRangeException()
      };
    }
  }
}