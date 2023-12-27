using System;
using System.Reflection;
using Code.StaticData.Level;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
  //[CustomPropertyDrawer(typeof(LevelConfig))]
  public class LevelConfigPropertyDrawer : PropertyDrawer
  {
    public static float padding = 0;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
      EditorGUI.BeginProperty(position, label, property);
      MethodInfo defaultDraw = typeof(EditorGUI).GetMethod("DefaultPropertyField", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
      defaultDraw.Invoke(null, new object[3] { position, property, label });
      if (GUI.Button(new Rect(position.x+padding, 10*position.y+padding, position.width-padding*2, EditorGUIUtility.singleLineHeight),"Generate"))
      {
        
      }
      EditorGUI.EndProperty();
      /*
     float propHeight = EditorGUIUtility.singleLineHeight;
     
     EditorGUI.BeginProperty(position, label, property);
     GUI.Box(position,"",new GUIStyle
     {
       border = new RectOffset(3, 3, 3, 3),
       padding = new RectOffset(0, 0, 0, 0),
       margin = new RectOffset(0, 0, 3, 3)
     });
     SerializedProperty id = property.FindPropertyRelative("Id");
     Rect contRect = new Rect(position.x+padding, position.y+padding, position.width-padding*2, propHeight);
      EditorGUI.LabelField(contRect, label.text, EditorStyles.boldLabel);
     
     
     Rect evalRect = new Rect(position.x+padding, position.y+propHeight+padding, position.width-padding*2, propHeight);
     
     Rect evalCtrl = EditorGUI.PrefixLabel(evalRect,new GUIContent("JellyMeshConfigs"));
     
     EditorGUI.PropertyField(evalCtrl, property.FindPropertyRelative("JellyMeshConfigs"),GUIContent.none);
     EditorGUI.EndProperty();
     */

    }
  }
}