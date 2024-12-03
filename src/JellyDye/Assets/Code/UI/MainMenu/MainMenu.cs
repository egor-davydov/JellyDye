using Code.Enums;
using UnityEngine;

namespace Code.UI.MainMenu
{
  public class MainMenu : MonoBehaviour, ITabOpener
  {
    [SerializeField] private Tab[] _tabs;

    private void Awake()
    {
      foreach (Tab tab in _tabs)
        tab.Initialize(this);
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