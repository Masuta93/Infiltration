using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WeaponObject))]
[CanEditMultipleObjects]
public class CustomClassView : UnityEditor.Editor
{
    SerializedProperty type;
    SerializedProperty WeaponType;

    void OnEnable()
    {
        type = serializedObject.FindProperty("type");
        WeaponType = serializedObject.FindProperty("weaponType");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(type);
        EditorGUILayout.PropertyField(WeaponType);
        serializedObject.ApplyModifiedProperties();
    }

    
}