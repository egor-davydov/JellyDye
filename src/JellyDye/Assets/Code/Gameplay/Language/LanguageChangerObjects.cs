using Code.Enums;
using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Language
{
  public class LanguageChangerObjects : MonoBehaviour
  {
    [SerializeField] private GameObject _enObject;
    [SerializeField] private GameObject _ruObject;

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
      if (playerLanguage == LanguageType.English)
      {
        _enObject.SetActive(true);
        _ruObject.SetActive(false);
      }
      else
      {
        _enObject.SetActive(false);
        _ruObject.SetActive(true);
      }
    }
  }
}