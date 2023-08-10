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
      
      if (GUILayout.Button("Setup jellies"))
      {
        foreach (JellyConfig jellyConfig in jelliesStaticData.JellyConfigs)
        {
          if (jellyConfig.Mesh == null)
            continue;
          if (jellyConfig.MaskTexture == null)
          {
            Texture2D texture2D = Resources.Load<Texture2D>("bordertex/" + jellyConfig.Mesh.name);
            if (texture2D == null)
            {
              Debug.LogError("No texture for mesh " + jellyConfig.Mesh.name);
              continue;
            }

            jellyConfig.MaskTexture = texture2D;
          }

          int countPixelsShouldPaint = 0;
          Texture2D maskTexture = jellyConfig.MaskTexture;
          for (int x = 0; x < maskTexture.width; x++)
          for (int y = 0; y < maskTexture.height; y++)
          {
            if (maskTexture.GetPixel(x, y).r == 0)
              countPixelsShouldPaint++;
          }

          jellyConfig.CountPixelsShouldPaint = countPixelsShouldPaint;
        }
      }
      EditorUtility.SetDirty(target);
    }
  }
}