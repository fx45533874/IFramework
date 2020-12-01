/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-09-12
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;
using System.Reflection;

namespace IFramework.GUITool.Inspector
{
    [CustomPropertyDrawer(typeof(SearchableStringAttribute))]
    public class SearchableStringDrawer : PropertyDrawer
    {
        private int idHash;
        private object GetParentObjectOfProperty(string path, object obj)
        {
            string[] fields = path.Split('.');
            if (fields.Length == 1) return obj;
            FieldInfo fi = obj.GetType().GetField(fields[0], BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            obj = fi.GetValue(obj);
            return GetParentObjectOfProperty(string.Join(".", fields, 1, fields.Length - 1), obj);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.type != "string")
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }
            SearchableStringAttribute sr = this.attribute as SearchableStringAttribute;
            object parent = GetParentObjectOfProperty(property.propertyPath, property.serializedObject.targetObject);

            string[] array = parent.GetType().GetField(sr.searchArray,BindingFlags.Public | BindingFlags.NonPublic| BindingFlags.Instance).GetValue(parent) as string[];

            if (array == null || array.Length==0)
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }
            if (idHash == 0) idHash = "SearchableStringDrawer".GetHashCode();
            int id = GUIUtility.GetControlID(idHash, FocusType.Keyboard, position);

            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, id, label);

            GUIContent buttonText =new GUIContent(property.stringValue);
            if (DropdownButton(id, position, buttonText))
            {
                int j = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]==property.stringValue)
                    {
                        j = i;
                        break;
                    }
                }
                SearchablePopup.Show(position, array,j, (index,str)=> {
                        property.stringValue = str;
                        property.serializedObject.ApplyModifiedProperties();
                    });
            }
            EditorGUI.EndProperty();
        }

        private static bool DropdownButton(int id, Rect position, GUIContent content)
        {
            Event current = Event.current;
            switch (current.type)
            {
                case EventType.MouseDown:
                    if (position.Contains(current.mousePosition) && current.button == 0)
                    {
                        Event.current.Use();
                        return true;
                    }
                    break;
                case EventType.KeyDown:
                    if (GUIUtility.keyboardControl == id && current.character == '\n')
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
