using System;
using System.Collections.Generic;
using System.Linq;
using Code.Services;
using Code.StaticData;
using Code.StaticData.Level;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
  
  [CustomEditor(typeof(LevelsStaticData)), CanEditMultipleObjects]
  public class LevelsStaticDataEditor : UnityEditor.Editor
  {
    private LevelsStaticData _levelsDataTarget;
    private SerializedProperty _colorCompareEpsilon;
    private SerializedProperty _levelConfigs;

    private void OnEnable()
    {
      _levelsDataTarget = (LevelsStaticData)target;
      
      _levelConfigs = serializedObject.FindProperty("LevelConfigs");
      _colorCompareEpsilon = serializedObject.FindProperty("ColorCompareEpsilon");
    }

    public override void OnInspectorGUI()
    {
      serializedObject.Update();
      // if (GUILayout.Button("Add target colors"))
      // {
      //   SetTargetDirty();
      //   foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
      //   {
      //     foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs)
      //     {
      //       levelConfig.AdditionalColors.Add(new LevelColor(jellyMeshConfig.TargetColor, true));
      //     }
      //   }
      // }
      var epsilon = 0.1f;
      if (GUILayout.Button($"Remove similar by epsilon {epsilon}"))
      {
        SetTargetDirty();
        foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
        {
          levelConfig.RemoveSimilarColorsByEpsilon(epsilon);
        }
      }

      /*
      if (GUILayout.Button("Transfer colors"))
      {
        SetTargetDirty();
        
        foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
        {
          levelConfig.AdditionalColors.Clear();
          foreach (Color levelConfigColor in levelConfig.AdditionalColors)
          {
            levelConfig.AdditionalColors.Add(levelConfigColor);
          }
        }
      }
      */
      /*if (GUILayout.Button("Transfer JellyMeshConfig's"))
      {
        SetTargetDirty();
        var staticDataService = new StaticDataService();
        staticDataService.Initialize();
        List<JellyMeshConfig> jellyMeshConfigs = staticDataService.ForJellies().JellyConfigs;
        foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
        {
          foreach (SkinnedMeshRenderer skinnedMeshRenderer in levelConfig.JelliesPrefab.GetComponentsInChildren<SkinnedMeshRenderer>())
          {
            JellyMeshConfig jellyMeshConfig = jellyMeshConfigs.First(config => config.Mesh == skinnedMeshRenderer.sharedMesh);
            levelConfig.JellyMeshConfigs.Add(jellyMeshConfig);
          }
        }
      }*/
      if (GUILayout.Button("ReValidate"))
      {
        SetTargetDirty();
        _levelsDataTarget.OnValidate();
      }
      DrawPropertiesExcluding(serializedObject, "m_Script");
      serializedObject.ApplyModifiedProperties();
    }

    private void SetTargetDirty()
    {
      EditorUtility.SetDirty(_levelsDataTarget);
    }
  }
}