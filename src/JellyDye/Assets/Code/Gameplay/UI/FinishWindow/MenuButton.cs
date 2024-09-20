using Code.Services.Factories.UI;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.UI.FinishWindow
{
  public class MenuButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _menuButton;
    
    private WindowFactory _windowFactory;

    [Inject]
    public void Construct(WindowFactory windowFactory)
    {
      _windowFactory = windowFactory;
    }
    private void Awake()
    {
      _menuButton.onClick.AddListener(UniTask.UnityAction(OpenMenu));
    }
    
    private async UniTaskVoid OpenMenu()
    {
      _uiAudio.PlayClick();
      await _windowFactory.CreateMainMenu();
    }
  }
}