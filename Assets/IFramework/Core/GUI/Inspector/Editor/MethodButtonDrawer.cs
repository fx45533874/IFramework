/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-05-12
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;
using System.Reflection;
using IFramework.GUITool;

namespace IFramework.GUITool.Inspector
{
    [CustomPropertyDrawer(typeof(MethodButtonAttribute))]
    internal class MethodButtonDrawer:PropertyDrawer
	{
        private MethodButtonAttribute method { get { return attribute as MethodButtonAttribute; } }

        private float BtnHeight
        {
            get
            {
               
                var style = GUIStyles.Get("Button");
                return style.lineHeight*2;
            }
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property,label)+BtnHeight;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (GUI.Button(new Rect(
                position.x,
                position.y,
                position.width,
                BtnHeight
                ),
               string .IsNullOrEmpty( method.name)?method.method:method.name))
            {
                MethodInfo info = property.serializedObject.targetObject. GetType().
                    GetMethod(method.method,
                                    BindingFlags.Instance | BindingFlags.Static |
                                    BindingFlags.Public | BindingFlags.NonPublic);
                info.Invoke(property.serializedObject.targetObject, null);
            }  
            EditorGUI.PropertyField(new Rect(
                position.x,
                position.y+BtnHeight,
                position.width,
                position.height- BtnHeight
                ), property, label);
        }
       
    }
}
