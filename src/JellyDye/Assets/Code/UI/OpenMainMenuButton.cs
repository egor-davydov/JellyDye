using Code.Enums;
using Code.Services.Providers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.UI
{
  public class OpenMainMenuButton : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _openMenuButton;

    private WindowsProvider _windowsProvider;

    [Inject]
    public void Construct(WindowsProvider windowsProvider) =>
      _windowsProvider = windowsProvider;

    private void Awake() =>
      _openMenuButton.onClick.AddListener(OpenMenuClick);

    private void OpenMenuClick()
    {
      _uiAudio.PlayClick();
      _windowsProvider.MainMenuWindow.OpenWindow();
      _windowsProvider.MainMenuWindow.OpenTab(TabType.Gallery);
    }
  }
}