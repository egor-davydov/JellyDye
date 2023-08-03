using Code.Gameplay;
using Code.Gameplay.Logic;
using Code.Helpers;
using Fluxy;
using Obi;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Code.Editor
{
  [CustomEditor(typeof(JellyAutoConstruct)), CanEditMultipleObjects]
  public class JellyAutoConstructEditor : UnityEditor.Editor
  {
    public JellyAutoConstruct jellyAutoConstruct;

    public void OnEnable()
    {
      jellyAutoConstruct = (JellyAutoConstruct)target;
    }

    public override void OnInspectorGUI()
    {
      serializedObject.Update();
      if (GUILayout.Button("Construct jelly"))
      {
        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        GameObject instantiatePrefab = (GameObject)PrefabUtility.InstantiatePrefab(jellyAutoConstruct.softbodyBasePrefab, jellyAutoConstruct.transform);
        ObiActor obiActor = instantiatePrefab.GetComponentInChildren<ObiActor>();
        Mesh mesh = jellyAutoConstruct.mesh;
        obiActor.gameObject.name = mesh.name;
        
        FluxyContainer fluxyContainer = instantiatePrefab.GetComponentInChildren<FluxyContainer>();
        fluxyContainer.customMesh = mesh;
        fluxyContainer.skinnedMeshRenderer.sharedMesh = mesh;
        instantiatePrefab.GetComponentInChildren<MeshCollider>().sharedMesh = mesh;
        GameObject parentGameObject = instantiatePrefab.transform.parent.gameObject;
        parentGameObject.GetComponentInChildren<FixObiParticles>()._obiActors.Add(obiActor);
        fluxyContainer.solver = parentGameObject.GetComponentInChildren<FluxySolver>();
        EditorGUIUtility.ExitGUI();
      }
      DrawPropertiesExcluding(serializedObject, "m_Script");

      // Apply changes to the serializedProperty
      if (GUI.changed)
      {
        serializedObject.ApplyModifiedProperties();
      }
    }
  }
}