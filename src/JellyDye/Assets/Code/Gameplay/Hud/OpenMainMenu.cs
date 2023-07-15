using Code.Services.Factories;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.MainMenu
{
  public class OpenMainMenu : MonoBehaviour
  {
    [SerializeField] private Button _openMenuButton;
    private UIFactory _uiFactory;

    [Inject]
    public void Construct(UIFactory uiFactory) => 
      _uiFactory = uiFactory;

    private void Awake() => 
      _openMenuButton.onClick.AddListener(OpenMenuClick);

    private void OpenMenuClick() => 
      _uiFactory.CreateMainMenu();
  }
}