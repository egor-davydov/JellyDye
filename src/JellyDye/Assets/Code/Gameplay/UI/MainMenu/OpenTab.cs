using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.MainMenu
{
  public class OpenTab : MonoBehaviour
  {
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _openTabButton;
    [SerializeField] private GameObject _tabToOpen;
    [SerializeField] private GameObject _tabToClose;

    private void Awake() => 
      _openTabButton.onClick.AddListener(OpenTabClick);

    private void OpenTabClick()
    {
      _uiAudio.PlayClick();
      _tabToClose.SetActive(false);
      _tabToOpen.SetActive(true);
    }
  }
}