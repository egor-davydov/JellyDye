using System.Linq;
using Code.Gameplay;
using Code.Gameplay.Logic;
using Code.Helpers;
using Code.Services;
using Fluxy;
using Obi;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Code.Editor
{
  [CustomEditor(typeof(JellyAutoActions)), CanEditMultipleObjects]
  public class JellyAutoActionsEditor : UnityEditor.Editor
  {
    private JellyAutoActions _jellyAutoTarget;

    public void OnEnable()
    {
      _jellyAutoTarget = (JellyAutoActions)target;
    }

    public override void OnInspectorGUI()
    {
      serializedObject.Update();
      if (GUILayout.Button("Resize and center containers"))
      {
        foreach (FluxyContainer fluxyContainer in _jellyAutoTarget.GetComponentsInChildren<FluxyContainer>())
        {
          fluxyContainer.size = Vector3.one;
          fluxyContainer.transform.localPosition = fluxyContainer.customMesh.bounds.center;
        }
        EditorUtility.SetDirty(_jellyAutoTarget);
      }
      if (GUILayout.Button("UnSetup for screenshot"))
      {
        foreach (FluxyContainer fluxyContainer in _jellyAutoTarget.GetComponentsInChildren<FluxyContainer>())
        {
          fluxyContainer.size = Vector3.one;
          fluxyContainer.transform.localPosition = fluxyContainer.customMesh.bounds.center;
        }
        EditorUtility.SetDirty(_jellyAutoTarget);
      }
      DrawPropertiesExcluding(serializedObject, "m_Script");
      serializedObject.ApplyModifiedProperties();
    }

  }
}