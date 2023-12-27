using System.Collections.Generic;
using UnityEngine;

namespace Code.Helpers
{
  public class TabsHelper : MonoBehaviour
  {
    [field: SerializeField] public List<GameObject> Tabs { get; private set; } = new(3);

    private void OnValidate() => 
      CheckForDuplicates();

    private void CheckForDuplicates()
    {
      for (int i = 0; i < Tabs.Count; i++)
      for (int j = i + 1; j < Tabs.Count; j++)
      {
        GameObject firstTab = Tabs[i];
        GameObject secondTab = Tabs[j];
        if (firstTab == secondTab)
          Tabs.Remove(firstTab);
      }
    }
  }
}