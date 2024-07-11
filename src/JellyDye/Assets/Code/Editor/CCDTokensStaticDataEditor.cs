using Code.StaticData.Token;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Code.Editor
{
  [CustomEditor(typeof(CCDTokensStaticData))]
  public class CCDTokensStaticDataEditor : UnityEditor.Editor, IPreprocessBuildWithReport
  {
    private static CCDTokensStaticData _tokensTarget;

    public int callbackOrder => 0;
    public void OnPreprocessBuild(BuildReport report) => Initialize();

    private void OnEnable()
    {
      _tokensTarget = ((CCDTokensStaticData)target);
    }

    [RuntimeInitializeOnLoadMethod]
    private static void Initialize()
    {
      AddressableAssetSettings settings = AddressableAssetSettingsDefaultObject.Settings;
      _tokensTarget.ActiveProfileName = settings.profileSettings.GetProfileName(settings.activeProfileId);
    }
  }
}