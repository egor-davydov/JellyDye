using Code.Helpers;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
  [CustomEditor(typeof(TabsHelper))]
  public class TabsHelperEditor : UnityEditor.Editor
  {
    private const int MinimumTabs = 2;
    
    private TabsHelper _tabsHelper;

    private void OnEnable() => 
      _tabsHelper = (TabsHelper)target;

    public override void OnInspectorGUI()
    {
      serializedObject.Update();
      DrawPropertiesExcluding(serializedObject, "m_Script");
      if (_tabsHelper.Tabs.Count > MinimumTabs - 1)
      {
        foreach (GameObject tab in _tabsHelper.Tabs)
        {
          GUI.enabled = !tab.activeSelf;
          if (GUILayout.Button($"Activate {tab.name}"))
          {
            ActivateOnlyOneTab(tabToActivate: tab);
            EditorUtility.SetDirty(_tabsHelper);
          }
        }
      }
      else
        EditorGUILayout.HelpBox($"Need at least \"{MinimumTabs}\" tabs", MessageType.Warning);

      serializedObject.ApplyModifiedProperties();
    }

    private void ActivateOnlyOneTab(GameObject tabToActivate)
    {
      foreach (GameObject tab in _tabsHelper.Tabs)
        tab.SetActive(tab == tabToActivate);
    }
  }
}