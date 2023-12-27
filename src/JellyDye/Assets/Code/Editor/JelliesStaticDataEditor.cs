using System.Collections.Generic;
using System.Linq;
using Code.StaticData;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
  [CustomEditor(typeof(JelliesStaticData))]
  public class JelliesStaticDataEditor : UnityEditor.Editor
  {
    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();
      JelliesStaticData jelliesStaticData = (JelliesStaticData)target;
      List<JellyMeshConfig> jellyConfigs = jelliesStaticData.JellyConfigs;

      if (GUILayout.Button("Load meshes and add configs"))
      {
        Mesh[] meshes = Resources.LoadAll<Mesh>("Levels/SoftBodies");
        foreach (Mesh mesh in meshes)
        {
          bool dontHaveConfigWithMesh = jellyConfigs.FirstOrDefault(config => config.Mesh == mesh) == default;
          if (dontHaveConfigWithMesh)
          {
            jelliesStaticData.JellyConfigs.Add(new JellyMeshConfig(mesh, Random.ColorHSV()));
          }
        }
      }
      if (GUILayout.Button("Setup jellies"))
      {
        foreach (JellyMeshConfig jellyConfig in jellyConfigs)
        {
          if (jellyConfig.Mesh == null)
            continue;
          if (jellyConfig.MaskTexture == null)
          {
            Texture2D texture2D = Resources.Load<Texture2D>("bordertex/" + jellyConfig.Mesh.name);
            if (texture2D == null)
            {
              texture2D = Resources.Load<Texture2D>(jellyConfig.Mesh.name);

              if (texture2D == null)
              {
                Debug.LogError("No texture for mesh " + jellyConfig.Mesh.name);
                continue;
              }
            }

            jellyConfig.SetMask(texture2D);
          }
        }
      }
      EditorUtility.SetDirty(target);
    }
  }
}