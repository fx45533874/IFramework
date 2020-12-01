/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-08-29
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework.GUITool;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace IFramework.Language
{
    [CustomPropertyDrawer(typeof(LanguageKeyAttribute))]
    class LanguageKeyDrawer:PropertyDrawer
	{
        private LanGroup _LanGroup { get { return AssetDatabase.LoadAssetAtPath<LanGroup>(EditorEnv.frameworkPath.CombinePath(LanGroup.assetPath)); } }
        private int _hashID;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.type != "string")
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }
            if (_hashID == 0) _hashID = "LanguageKeyDrawer".GetHashCode();
            int ctrlId = GUIUtility.GetControlID(_hashID, FocusType.Keyboard, position);
            {
                label = EditorGUI.BeginProperty(position, label, property);
                position = EditorGUI.PrefixLabel(position, ctrlId, label);
                if (DropdownButton(ctrlId, position, new GUIContent(property.stringValue)))
                {
                    int index = -1;
                    for (int i = 0; i < _LanGroup.keys.Count; i++)
                    {
                        if (_LanGroup.keys[i]== property.stringValue)
                        {
                            index = i;
                            break;
                        }
                    }
                    SearchablePopup.Show(position, _LanGroup.keys.ToArray(), index, (i, str) =>
                    {
                        property.stringValue = str;
                        property.serializedObject.ApplyModifiedProperties();
                    });
                }
            }
            EditorGUI.EndProperty();
        }

        private static bool DropdownButton(int id, Rect position, GUIContent content)
        {
            Event e = Event.current;
            switch (e.type)
            {
                case EventType.MouseDown:
                    if (position.Contains(e.mousePosition) && e.button == 0)
                    {
                        Event.current.Use();
                        return true;
                    }
                    break;
                case EventType.KeyDown:
                    if (GUIUtility.keyboardControl == id && e.character == '\n')
                    {
                        Event.current.Use();
                        return true;
                    }
                    break;
                case EventType.Repaint:
                    EditorStyles.toolbarTextField.Draw(position, content, id, false);
                    break;
            }
            return false;
        }

    }
}
