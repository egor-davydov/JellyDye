using Code.Services.Factories;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Hud
{
  public class OpenSettings : MonoBehaviour
  {
    [SerializeField] private Button _openSettingsButton;
    private UIFactory _uiFactory;

    [Inject]
    public void Construct(UIFactory uiFactory) => 
      _uiFactory = uiFactory;

    private void Awake() => 
      _openSettingsButton.onClick.AddListener(OpenSettingsClick);

    private void OpenSettingsClick() => 
      _uiFactory.CreateSettingsWindow();
  }
}