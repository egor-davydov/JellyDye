using System;
using Code.Services;
using TMPro;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Language
{
  public class LanguageChangerText : MonoBehaviour
  {
    [field: SerializeField] public string EnText { get; private set; }
    [field: SerializeField] public string RuText { get; private set; }
    [SerializeField] private bool _useForTransfer;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    
    private PublishService _publishService;

    public string ResultText { get; private set; }

    [Inject]
    public void Construct(PublishService publishService)
    {
      _publishService = publishService;
      
      LanguageType playerLanguage = _publishService.GetPlayerLanguage();
      ResultText = playerLanguage switch
      {
        LanguageType.English => EnText,
        LanguageType.Russian => RuText,
        _ => throw new ArgumentOutOfRangeException()
      };
      
      if(!_useForTransfer)
        ChangeLanguage();
    }

    private void ChangeLanguage() => 
      _textMeshPro.text = ResultText;
  }
}