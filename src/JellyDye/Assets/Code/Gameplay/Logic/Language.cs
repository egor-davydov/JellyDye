using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Logic
{
  public class Language : MonoBehaviour
  {
    [SerializeField] private GameObject _ruGameName;
    [SerializeField] private GameObject _enGameName;
    
    private YandexService _yandexService;

    [Inject]
    public void Construct(YandexService yandexService)
    {
      _yandexService = yandexService;
      SetupGameName();
    }

    private void SetupGameName()
    {
      LanguageType playerLanguage = _yandexService.GetPlayerLanguage();
      if (playerLanguage == LanguageType.English)
      {
        _enGameName.SetActive(true);
        _ruGameName.SetActive(false);
      }
      else
      {
        _enGameName.SetActive(false);
        _ruGameName.SetActive(true);
      }
    }

  }
}