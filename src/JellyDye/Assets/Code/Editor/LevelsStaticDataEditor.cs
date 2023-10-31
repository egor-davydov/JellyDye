using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Code.Constants;
using Code.Helpers;
using Code.StaticData;
using Code.StaticData.Level;
using Obi;
using UnityEditor;
using UnityEngine;
using static Obi.ObiSoftbodySurfaceBlueprint;
using BooleanPreference = Fluxy.BooleanPreference;

namespace Code.Editor
{
  [CustomEditor(typeof(LevelsStaticData)), CanEditMultipleObjects]
  public class LevelsStaticDataEditor : UnityEditor.Editor
  {
    private const int MinimumMeshesToGenerateLevel = 2;

    private LevelsStaticData _levelsDataTarget;

    private BooleanPreference _advanceOptions;
    private BooleanPreference _tools;

    private void OnEnable()
    {
      _levelsDataTarget = (LevelsStaticData)target;
      _advanceOptions = new BooleanPreference($"{target.GetType()}.advanceOptions", true);
      _tools = new BooleanPreference($"{target.GetType()}.tools", true);
      // foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
      // {
      //   foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs) 
      //     jellyMeshConfig.SetTargetColorAlphaToOne();
      // }
    }

    public override void OnInspectorGUI()
    {
      serializedObject.Update();
      LevelConfig[] levelConfigs = _levelsDataTarget.LevelConfigs;
      // var epsilon = 0.1f;
      // if (GUILayout.Button($"Remove similar by epsilon {epsilon}"))
      // {
      //   SetTargetDirty();
      //   foreach (LevelConfig levelConfig in levelConfigs)
      //   {
      //     levelConfig.RemoveSimilarColorsByEpsilon(epsilon);
      //   }
      // }


      DrawPropertiesExcluding(serializedObject, "m_Script");
      LevelConfig lastLevelConfig = _levelsDataTarget.LevelConfigs.Last();
      string lastLevelId = lastLevelConfig.Id;
      string newBlueprintsFolder = $"{FolderPath.AbsoluteBlueprintsPath}/{lastLevelId}";
      var jellyBasePath = $"{FolderPath.AbsolutePrefabsPath}/{lastLevelId}.prefab";
      if (lastLevelConfig.JelliesPrefab == null)
      {
        List<JellyMeshConfig> lastLevelJellyConfigs = lastLevelConfig.JellyMeshConfigs;

        if (lastLevelJellyConfigs.Count >= MinimumMeshesToGenerateLevel
            && lastLevelJellyConfigs.All(x => x.Mesh != null))
        {
          if (GUILayout.Button(ButtonNameGenerateLevel(lastLevelId)))
          {
            RenameAndMoveMeshesAndMasks(lastLevelConfig, newBlueprintsFolder);
            GenerateNewLevel(jellyBasePath, lastLevelConfig, newBlueprintsFolder);
            // foreach (JellyMeshConfig jellyMeshConfig in lastLevelJellyConfigs) 
            //   jellyMeshConfig.SetTargetColorAlphaToOne();

            SetTargetDirty();
          }

          _advanceOptions.value = EditorGUILayout.BeginFoldoutHeaderGroup(_advanceOptions, "Advance options");
          if (_advanceOptions)
          {
            if (GUILayout.Button(ButtonNameRenameAndMove()))
            {
              RenameAndMoveMeshesAndMasks(lastLevelConfig, newBlueprintsFolder);
              SetTargetDirty();
            }

            if (GUILayout.Button("Generate blueprints"))
            {
              GenerateOrGetBlueprints(lastLevelConfig, newBlueprintsFolder);
              SetTargetDirty();
            }
          }

          EditorGUILayout.EndFoldoutHeaderGroup();
        }
        else
          EditorGUILayout.HelpBox($"To generate level you should add at least {MinimumMeshesToGenerateLevel} meshes", MessageType.Warning);
      }
      else
      {
        GameObject jellyBase = lastLevelConfig.JelliesPrefab;
        if (jellyBase != null)
        {
          if (GUILayout.Button($"Open {GetInQuotationMarks(lastLevelId)} prefab"))
            AssetDatabase.OpenAsset(jellyBase);

          if (GUILayout.Button($"Delete last prefab {GetInQuotationMarks(lastLevelId)}"))
          {
            AssetDatabase.DeleteAsset(jellyBasePath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
          }
          if (GUILayout.Button($"Rebind skin {GetInQuotationMarks(lastLevelId)}"))
          {
            foreach (ObiSoftbodySkinner skinner in jellyBase.GetComponentsInChildren<ObiSoftbodySkinner>())
            {
              IEnumerator bindSkinEnumerator = skinner.BindSkin();
              while (bindSkinEnumerator.MoveNext()) {}
            }
            EditorUtility.SetDirty(jellyBase);
            AssetDatabase.SaveAssetIfDirty(jellyBase);
          }
        }


        if (GUILayout.Button($"TO DEFAULT {GetInQuotationMarks(lastLevelId)}(Without instant save)"))
        {
          lastLevelConfig.Id = "default";
          lastLevelConfig.AdditionalColors = new(5);
          lastLevelConfig.JellyMeshConfigs = new(5);
          lastLevelConfig.JellyMeshConfigs.Add(new JellyMeshConfig(null, Color.white));
          lastLevelConfig.JellyMeshConfigs.Add(new JellyMeshConfig(null, Color.white));
          lastLevelConfig.JelliesPrefab = default;
          lastLevelConfig.TargetTexture = default;
          lastLevelConfig.TargetTextureWithGround = default;
        }

        if (GUILayout.Button(ButtonNameRenameAndMove()))
        {
          RenameAndMoveMeshesAndMasks(lastLevelConfig, newBlueprintsFolder);
          SetTargetDirty();
        }

        _tools.value = EditorGUILayout.BeginFoldoutHeaderGroup(_tools, "Tools");
        if (_tools)
        {
          if (GUILayout.Button("ReValidate"))
          {
            _levelsDataTarget.OnValidate();
            SetTargetDirty();
          }

          if (GUILayout.Button("Add random additional color"))
          {
            foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
            {
              var isUniqueColorFound = false;
              for (int i = 0; i < 100; i++)
              {
                Color randomColor = new Color(
                  Random.Range(0f, 1f),
                  Random.Range(0f, 1f),
                  Random.Range(0f, 1f)
                );
                var newRandomColorSimilar = false;
                foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs)
                {
                  if (MathHelp.VectorsSimilar(jellyMeshConfig.TargetColor, randomColor, _levelsDataTarget.ColorCompareEpsilon))
                  {
                    newRandomColorSimilar = true;
                    break;
                  }
                }

                if (newRandomColorSimilar == false)
                {
                  levelConfig.AdditionalColors.Add(randomColor);
                  isUniqueColorFound = true;
                  break;
                }
              }

              if (!isUniqueColorFound)
                Debug.LogWarning($"Didn't found new unique color for {GetInQuotationMarks(levelConfig.Id)}");
            }

            SetTargetDirty();
          }

          if (GUILayout.Button("Setup screenshots"))
          {
            SetupAllScreenshots();

            AssetsSaveAndRefresh();
            SetTargetDirty();
          }
        }
      }

      foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
      {
        foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs)
          jellyMeshConfig.SetTargetColorAlphaToOne();
      }

      serializedObject.ApplyModifiedProperties();
    }

    private void ChangeTextureImportSettings(Texture2D texture2D)
    {
      TextureImporter targetTextureImporter = (TextureImporter)AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(texture2D));
      targetTextureImporter.maxTextureSize = 1024;
      targetTextureImporter.crunchedCompression = true;
      targetTextureImporter.mipmapEnabled = false;
    }

    public void SetupAllScreenshots()
    {
      Texture2D[] texture2Ds = Resources.LoadAll<Texture2D>(FolderPath.ResourcesScreenshotsPath);
      if (texture2Ds.Length == 0)
      {
        Debug.LogError("Can't find screenshot textures");
        return;
      }

      foreach (LevelConfig levelConfig in _levelsDataTarget.LevelConfigs)
      {
        if (levelConfig.TargetTexture != null)
          continue;
        levelConfig.TargetTexture = texture2Ds.First(texture2D => texture2D.name == levelConfig.JelliesPrefab.name);
        ChangeTextureImportSettings(levelConfig.TargetTexture);
        if (levelConfig.TargetTextureWithGround != null)
          continue;
        levelConfig.TargetTextureWithGround = texture2Ds.First(texture2D => texture2D.name == levelConfig.JelliesPrefab.name + "_ground");
        ChangeTextureImportSettings(levelConfig.TargetTextureWithGround);
      }
    }

    private string ButtonNameRenameAndMove() =>
      "RENAME AND MOVE (meshes and masks)";

    private string ButtonNameGenerateLevel(string lastLevelId) =>
      $"GENERATE LEVEL (from meshes of {GetInQuotationMarks(lastLevelId)})";

    private string GetInQuotationMarks(string text) =>
      $"\"{text}\"";

    private void GenerateNewLevel(string newJellyBasePath, LevelConfig lastLevelConfig, string newBlueprintsFolder)
    {
      var blueprints = GenerateOrGetBlueprints(lastLevelConfig, newBlueprintsFolder);
      GeneratePrefab(newJellyBasePath, lastLevelConfig, blueprints);
    }

    private void GeneratePrefab(string newJellyBasePath, LevelConfig lastLevelConfig, List<ObiSoftbodySurfaceBlueprint> blueprints)
    {
      GameObject softbodyPrefab = Resources.Load<GameObject>($"{FolderPath.ResourcesPrefabsPath}/{AssetName.SoftbodySolver}");
      GameObject jellyBasePrefab = Resources.Load<GameObject>($"{FolderPath.ResourcesPrefabsPath}/{AssetName.JellyBase}");
      GameObject jellyBase = CreatePrefabVariantAsset(jellyBasePrefab, newJellyBasePath);
      AssetsSaveAndRefresh();
      GameObject jellyBaseContents = PrefabUtility.LoadPrefabContents(newJellyBasePath);

      foreach (JellyMeshConfig jellyConfig in lastLevelConfig.JellyMeshConfigs)
      {
        Mesh withMesh = jellyConfig.Mesh;
        ObiSoftbodySurfaceBlueprint blueprint = blueprints.First(x => x.inputMesh == withMesh);

        InstantiateAndWireUpJelly(softbodyPrefab, withMesh, jellyBaseContents, blueprint);
      }

      PrefabUtility.SaveAsPrefabAsset(jellyBaseContents, newJellyBasePath);
      lastLevelConfig.JelliesPrefab = jellyBase;
      PrefabUtility.UnloadPrefabContents(jellyBaseContents);
    }

    private GameObject InstantiateAndWireUpJelly(GameObject softbodyPrefab, Mesh withMesh, GameObject jellyBase, ObiSoftbodySurfaceBlueprint meshBlueprint)
    {
      GameObject newSoftbodyObject = (GameObject)PrefabUtility.InstantiatePrefab(softbodyPrefab, jellyBase.transform);
      newSoftbodyObject.transform.localPosition = Vector3.zero;

      JellyAutoWireUp.WireUpJelly(newSoftbodyObject, withMesh, jellyBase, meshBlueprint);
      return newSoftbodyObject;
    }

    private void RenameAndMoveMeshesAndMasks(LevelConfig lastLevelConfig, string newBlueprintsFolder)
    {
      List<JellyMeshConfig> lastLevelJellyConfigs = lastLevelConfig.JellyMeshConfigs;
      string newName = lastLevelConfig.Id;
      CreateDirectoryIfNotExist(newBlueprintsFolder);
      for (var index = 0; index < lastLevelJellyConfigs.Count; index++)
      {
        JellyMeshConfig jellyConfig = lastLevelJellyConfigs[index];

        Mesh mesh = jellyConfig.Mesh;
        Texture2D maskTexture = jellyConfig.MaskTexture != null
          ? jellyConfig.MaskTexture
          : LoadMaskInResourcesByName(mesh.name);

        if (maskTexture != null)
        {
          AssetDatabase.RenameAsset(GetAssetPath(maskTexture), $"{newName}_mask_{index + 1}");
          AssetDatabase.MoveAsset(GetAssetPath(maskTexture), $"{newBlueprintsFolder}/{maskTexture.name}.png");
          jellyConfig.SetMask(maskTexture);
        }
        else
          Debug.LogWarning($"Can't find maskTexture for {mesh.name}");

        AssetDatabase.RenameAsset(GetAssetPath(mesh), $"{newName}_{index + 1}");
        AssetDatabase.MoveAsset(GetAssetPath(mesh), $"{newBlueprintsFolder}/{mesh.name}.asset");
      }

      GameObject jelliesPrefab = lastLevelConfig.JelliesPrefab;
      if (jelliesPrefab != null)
      {
        string oldName = jelliesPrefab.name;
        string oldFolder = $"{FolderPath.ResourcesBlueprintsPath}/{oldName}";
        
        foreach (ObiSoftbodySurfaceBlueprint blueprint in Resources.LoadAll<ObiSoftbodySurfaceBlueprint>(oldFolder))
        {
          AssetDatabase.RenameAsset(GetAssetPath(blueprint), $"{newName}_bp_{blueprint.name.Last()}");
          AssetDatabase.MoveAsset(GetAssetPath(blueprint), $"{newBlueprintsFolder}/{blueprint.name}.asset");
        }

        foreach (ObiSoftbodySkinner skinner in jelliesPrefab.GetComponentsInChildren<ObiSoftbodySkinner>()) 
          skinner.name = skinner.m_Target.sharedMesh.name;
        EditorUtility.SetDirty(jelliesPrefab);
        
        AssetDatabase.RenameAsset(GetAssetPath(jelliesPrefab), newName);
        Resources.UnloadUnusedAssets();
        string oldFolderAbsolutePath = $"{FolderPath.ResourcesFolderAbsolutePath}/{oldFolder}";
        if (oldName != newName && Directory.Exists(oldFolderAbsolutePath))
        {
          Directory.Delete(oldFolderAbsolutePath);
          File.Delete(oldFolderAbsolutePath + ".meta");
        }
      }

      AssetsSaveAndRefresh();
    }

    private List<ObiSoftbodySurfaceBlueprint> GenerateOrGetBlueprints(LevelConfig lastLevelConfig, string newBlueprintsFolder)
    {
      List<JellyMeshConfig> lastLevelJellyConfigs = lastLevelConfig.JellyMeshConfigs;
      List<ObiSoftbodySurfaceBlueprint> blueprints = new(5);
      for (var index = 0; index < lastLevelJellyConfigs.Count; index++)
      {
        JellyMeshConfig jellyConfig = lastLevelJellyConfigs[index];

        CreateDirectoryIfNotExist(newBlueprintsFolder);
        string newBlueprintName = $"{lastLevelConfig.Id}_bp_{index + 1}";
        string newBlueprintAbsolutePath = $"{newBlueprintsFolder}/{newBlueprintName}.asset";
        if (File.Exists(newBlueprintAbsolutePath))
        {
          blueprints.Add(Resources.Load<ObiSoftbodySurfaceBlueprint>($"{FolderPath.ResourcesBlueprintsPath}/{lastLevelConfig.Id}/{newBlueprintName}"));
          continue;
        }

        var softbodyBlueprint = CreateInstance<ObiSoftbodySurfaceBlueprint>();
        blueprints.Add(softbodyBlueprint);
        AssetDatabase.CreateAsset(softbodyBlueprint, newBlueprintAbsolutePath);

        Mesh configMesh = jellyConfig.Mesh;
        softbodyBlueprint.inputMesh = configMesh;
        softbodyBlueprint.surfaceSamplingMode = SurfaceSamplingMode.Vertices;
        int calculatedResolution = Mathf.CeilToInt((float)configMesh.vertexCount / _levelsDataTarget.VerticesCountToGenerateOneObiParticle);
        Debug.Log($"Calculated blueprint resolution of {GetInQuotationMarks(configMesh.name)} is {calculatedResolution}");
        softbodyBlueprint.surfaceResolution = Mathf.Clamp(calculatedResolution, _levelsDataTarget.MinGeneratedResolution, _levelsDataTarget.MaxGeneratedResolution);
        softbodyBlueprint.GenerateImmediate();
        EditorUtility.SetDirty(softbodyBlueprint);
        AssetsSaveAndRefresh();
      }

      return blueprints;
    }

    private string GetAssetPath(Object asset) =>
      AssetDatabase.GetAssetPath(asset);

    private Texture2D LoadMaskInResourcesByName(string meshName)
    {
      Texture2D texture2D = Resources.Load<Texture2D>("bordertex/" + meshName);
      if (texture2D != null) return texture2D;
      texture2D = Resources.Load<Texture2D>(meshName);

      if (texture2D != null) return texture2D;
      Debug.LogError("No texture for mesh " + meshName);
      return texture2D;
    }

    private GameObject CreatePrefabVariantAsset(GameObject originalPrefab, string newAssetPath)
    {
      GameObject newPrefab = (GameObject)PrefabUtility.InstantiatePrefab(originalPrefab);
      GameObject prefabVariant = PrefabUtility.SaveAsPrefabAsset(newPrefab, newAssetPath);
      DestroyImmediate(newPrefab);
      return prefabVariant;
    }


    private void CreateDirectoryIfNotExist(string newBlueprintsFolder)
    {
      if (Directory.Exists(newBlueprintsFolder))
        return;

      Directory.CreateDirectory(newBlueprintsFolder);
      AssetsSaveAndRefresh();
    }

    private void SetTargetDirty() =>
      EditorUtility.SetDirty(_levelsDataTarget);

    private void AssetsSaveAndSelect(Object asset)
    {
      AssetsSaveAndRefresh();
      EditorUtility.FocusProjectWindow();
      Selection.activeObject = asset;
    }

    private void AssetsSaveAndRefresh()
    {
      AssetDatabase.SaveAssets();
      AssetDatabase.Refresh();
    }
  }
}