using Code.Services.Factories;
using Code.Services.Factories.UI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Hud
{
  public class OpenMainMenu : MonoBehaviour
  {
    [SerializeField] private Button _openMenuButton;
    private WindowFactory _windowFactory;

    [Inject]
    public void Construct(WindowFactory windowFactory) => 
      _windowFactory = windowFactory;

    private void Awake() => 
      _openMenuButton.onClick.AddListener(OpenMenuClick);

    private void OpenMenuClick() => 
      _windowFactory.CreateMainMenu();
  }
}