using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Logic
{
  public class Language : MonoBehaviour
  {
    [SerializeField] private GameObject _ruGameName;
    [SerializeField] private GameObject _enGameName;
    
    private PublishService _publishService;

    [Inject]
    public void Construct(PublishService publishService)
    {
      _publishService = publishService;
      
      if (PublishService.IsSdkInitialized)
        SetupGameName();
      else
        PublishService.OnYandexSdkInitialized += SetupGameName;
    }
    

    private void SetupGameName()
    {
      LanguageType playerLanguage = _publishService.GetPlayerLanguage();
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