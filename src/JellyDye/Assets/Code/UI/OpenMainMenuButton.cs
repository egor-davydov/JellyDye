using Code.Services.Factories.UI;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI
{
  public class OpenMainMenuButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _openMenuButton;

    private WindowFactory _windowFactory;

    [Inject]
    public void Construct(WindowFactory windowFactory) =>
      _windowFactory = windowFactory;

    private void Awake() =>
      _openMenuButton.onClick.AddListener(OpenMenuClick);

    private void OpenMenuClick()
    {
      _uiAudio.PlayClick();
      _windowFactory.CreateMainMenu().Forget();
    }
  }
}