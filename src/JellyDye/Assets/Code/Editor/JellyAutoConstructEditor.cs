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

      StaticDataService staticDataService = new StaticDataService();
      staticDataService.Initialize();
      if (GUILayout.Button("Set clear color and texture"))
      {
        foreach (FluxyContainer fluxyContainer in jellyAutoConstruct.GetComponentsInChildren<FluxyContainer>())
        {
          fluxyContainer.clearColor = staticDataService.ForJellies().JellyConfigs.First(config => config.Mesh == fluxyContainer.customMesh).TargetColor;
          fluxyContainer.clearTexture = Resources.Load<Texture2D>("Textures/square");
        }
      }
      if (GUILayout.Button("Delete clear texture"))
      {
        foreach (FluxyContainer fluxyContainer in jellyAutoConstruct.GetComponentsInChildren<FluxyContainer>())
          fluxyContainer.clearTexture = null;
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