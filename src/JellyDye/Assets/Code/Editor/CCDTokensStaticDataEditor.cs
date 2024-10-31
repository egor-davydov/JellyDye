using System.Linq;
using Code.StaticData.Token;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace Code.Editor
{
  [CustomEditor(typeof(CCDTokensStaticData))]
  public class CCDTokensStaticDataEditor : UnityEditor.Editor
  {
    private static CCDTokensStaticData _tokensTarget;

    private void OnEnable()
    {
      _tokensTarget = (CCDTokensStaticData)target;
    }

    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();
      string activeProfileName = _tokensTarget.ActiveProfileName;
      GUI.enabled = !HasActiveProfile(activeProfileName);
      if (GUILayout.Button("Add active profile"))
      {
        _tokensTarget.Configs.Add(new CCDTokenConfig(activeProfileName));
        EditorUtility.SetDirty(target);
      }

      GUI.enabled = true;

      if (GUILayout.Button("Set active profile"))
        SetActiveProfile();
    }

    private bool HasActiveProfile(string activeProfileName) =>
      _tokensTarget.Configs.FirstOrDefault(config => config.ProfileName == activeProfileName) != default;

    private void SetActiveProfile()
    {
      AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
      _tokensTarget.ActiveProfileName = settings.profileSettings.GetProfileName(settings.activeProfileId);
      EditorUtility.SetDirty(target);
    }
  }
}