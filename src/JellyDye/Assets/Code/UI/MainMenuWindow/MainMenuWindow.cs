using Code.Enums;
using UnityEngine;

namespace Code.UI.MainMenuWindow
{
  public class MainMenuWindow : MonoBehaviour, ITabOpener, IWindow
  {
    [SerializeField] private Tab[] _tabs;

    private void Awake()
    {
      foreach (Tab tab in _tabs)
        tab.Initialize(this);
    }

    public bool IsOpen { get; private set; } = true;

    public void OpenWindow() =>
      SetActiveWindow(true);

    public void CloseWindow() =>
      SetActiveWindow(false);

    private void SetActiveWindow(bool isActive)
    {
      IsOpen = isActive;
      gameObject.SetActive(isActive);
    }

    public void OpenTab(TabType tabTypeToOpen)
    {
      foreach (Tab tab in _tabs)
      {
        if (tab.Type == tabTypeToOpen)
        {
          tab.ActivateTab(true);
          continue;
        }

        tab.ActivateTab(false);
      }
    }
  }
}