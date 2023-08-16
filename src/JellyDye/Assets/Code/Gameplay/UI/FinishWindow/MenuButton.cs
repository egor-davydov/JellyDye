using Code.Services.Factories.UI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class MenuButton : MonoBehaviour
  {
    [SerializeField] private Button _menuButton;
    
    private WindowFactory _windowFactory;

    [Inject]
    public void Construct(WindowFactory windowFactory)
    {
      _windowFactory = windowFactory;
    }
    private void Awake()
    {
      _menuButton.onClick.AddListener(OpenMenu);
    }
    
    private void OpenMenu()
    {
      _windowFactory.CreateMainMenu();
    }
  }
}