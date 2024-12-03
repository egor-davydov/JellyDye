using Code.Enums;
using UnityEngine;
using UnityEngine.UI;

namespace Code.UI.MainMenu
{
  public class Tab : MonoBehaviour
  {
    [field: SerializeField] public TabType Type { get; private set; }
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _openTabButton;
    [SerializeField] private GameObject _tabObject;

    private ITabOpener _tabOpener;

    public void Initialize(ITabOpener tabOpener) =>
      _tabOpener = tabOpener;

    private void Awake() =>
      _openTabButton.onClick.AddListener(OpenTabClick);

    private void OpenTabClick()
    {
      _uiAudio.PlayClick();
      _tabOpener.OpenTab(Type);
    }

    public void ActivateTab(bool isActivate) =>
      _tabObject.SetActive(isActivate);
  }
}