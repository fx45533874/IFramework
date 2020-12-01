/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-08-28
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Internal;

namespace IFramework.GUITool
{
    public static partial class ILayoutGUIEditorEx
    {
        public static ILayoutGUI Space(this ILayoutGUI self)
        {
            EditorGUILayout.Space();
            return self;
        }
        public static ILayoutGUI Separator(this ILayoutGUI self)
        {
            EditorGUILayout.Separator();
            return self;
        }
        public static ILayoutGUI InspectorTitlebar(this ILayoutGUI self, UnityEngine.Object[] targetObjs)
        {
            EditorGUILayout.InspectorTitlebar(targetObjs);
            return self;
        }
        public static ILayoutGUI DropdownButton(this ILayoutGUI self, Action<bool> listener, GUIContent content, FocusType focusType, GUIStyle style, params GUILayoutOption[] options)
        {
            if (listener != null)
            {
                listener(EditorGUILayout.DropdownButton(content, focusType, style, options));
            }
            else
            {
                EditorGUILayout.DropdownButton(content, focusType, style, options);
            }
            return self;
        }
        public static ILayoutGUI DropdownButton(this ILayoutGUI self, Action<bool> listener, GUIContent content, FocusType focusType, params GUILayoutOption[] options)
        {
            if (listener != null)
            {
                listener(EditorGUILayout.DropdownButton(content, focusType, options));
            }
            else
            {
                EditorGUILayout.DropdownButton(content, focusType, options);
            }
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
        {
            EditorGUILayout.IntPopup(property, displayedOptions, optionValues, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.IntPopup(property, displayedOptions, optionValues, label, options);
            return self;
        }
        public static ILayoutGUI HelpBox(this ILayoutGUI self, string message, UnityEditor.MessageType type, bool wide)
        {
            EditorGUILayout.HelpBox(message, type, wide);
            return self;
        }
        public static ILayoutGUI HelpBox(this ILayoutGUI self, string message, UnityEditor.MessageType type)
        {
            EditorGUILayout.HelpBox(message, type);
            return self;
        }
        public static ILayoutGUI ObjectField(this ILayoutGUI self, SerializedProperty property, Type objType, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.ObjectField(property, objType, label, options);
            return self;
        }
        public static ILayoutGUI ObjectField(this ILayoutGUI self, SerializedProperty property, Type objType, params GUILayoutOption[] options)
        {
            EditorGUILayout.ObjectField(property, objType, options);
            return self;
        }
        public static ILayoutGUI ObjectField(this ILayoutGUI self, SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.ObjectField(property, label, options);
            return self;
        }
        public static ILayoutGUI ObjectField(this ILayoutGUI self, SerializedProperty property, params GUILayoutOption[] options)
        {
            EditorGUILayout.ObjectField(property, options);
            return self;
        }
        public static ILayoutGUI Slider(this ILayoutGUI self, SerializedProperty property, float leftValue, float rightValue, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
            return self;
        }
        public static ILayoutGUI Slider(this ILayoutGUI self, SerializedProperty property, float leftValue, float rightValue, string label, params GUILayoutOption[] options)
        {
            EditorGUILayout.Slider(property, leftValue, rightValue, label, options);
            return self;
        }
        public static ILayoutGUI Slider(this ILayoutGUI self, SerializedProperty property, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            EditorGUILayout.Slider(property, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI IntSlider(this ILayoutGUI self, SerializedProperty property, int leftValue, int rightValue, params GUILayoutOption[] options)
        {
            EditorGUILayout.IntSlider(property, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI IntSlider(this ILayoutGUI self, SerializedProperty property, int leftValue, int rightValue, string label, params GUILayoutOption[] options)
        {
            EditorGUILayout.IntSlider(property, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI IntSlider(this ILayoutGUI self, SerializedProperty property, int leftValue, int rightValue, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.IntSlider(property, leftValue, rightValue, label, options);
            return self;
        }
        public static ILayoutGUI PrefixLabel(this ILayoutGUI self, string label, [DefaultValue("\"Button\"")] GUIStyle followingStyle)
        {
            EditorGUILayout.PrefixLabel(label, followingStyle);
            return self;
        }
        public static ILayoutGUI PrefixLabel(this ILayoutGUI self, string label)
        {
            EditorGUILayout.PrefixLabel(label);
            return self;
        }
        public static ILayoutGUI PrefixLabel(this ILayoutGUI self, GUIContent label, [DefaultValue("\"Button\"")] GUIStyle followingStyle)
        {
            EditorGUILayout.PrefixLabel(label, followingStyle);
            return self;
        }
        public static ILayoutGUI PrefixLabel(this ILayoutGUI self, GUIContent label)
        {
            EditorGUILayout.PrefixLabel(label);
            return self;
        }
        public static ILayoutGUI PrefixLabel(this ILayoutGUI self, string label, GUIStyle followingStyle, GUIStyle labelStyle)
        {
            EditorGUILayout.PrefixLabel(label, followingStyle, followingStyle);
            return self;
        }
        public static ILayoutGUI PrefixLabel(this ILayoutGUI self, GUIContent label, GUIStyle followingStyle, GUIStyle labelStyle)
        {
            EditorGUILayout.PrefixLabel(label, followingStyle, followingStyle);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, string label, string label2, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, label2, style, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, GUIContent label, GUIContent label2, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, label2, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, GUIContent label, GUIContent label2, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, label2, style, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, string label, string label2, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, label2, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, string label, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, GUIContent label, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, style, options);
            return self;
        }
        public static ILayoutGUI LabelField(this ILayoutGUI self, string label, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.LabelField(label, style, options);
            return self;
        }
        public static ILayoutGUI SelectableLabel(this ILayoutGUI self, string text, params GUILayoutOption[] options)
        {
            EditorGUILayout.SelectableLabel(text, options);
            return self;
        }
        public static ILayoutGUI SelectableLabel(this ILayoutGUI self, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.SelectableLabel(text, style, options);
            return self;
        }
        public static ILayoutGUI MinMaxSlider(this ILayoutGUI self, string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options)
        {
            EditorGUILayout.MinMaxSlider(label, ref minValue, ref maxValue, minLimit, maxLimit, options);
            return self;
        }
        public static ILayoutGUI MinMaxSlider(this ILayoutGUI self, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options)
        {
            EditorGUILayout.MinMaxSlider(ref minValue, ref maxValue, minLimit, maxLimit, options);
            return self;
        }
        public static ILayoutGUI MinMaxSlider(this ILayoutGUI self, GUIContent label, ref float minValue, ref float maxValue, float minLimit, float maxLimit, params GUILayoutOption[] options)
        {
            EditorGUILayout.MinMaxSlider(label, ref minValue, ref maxValue, minLimit, maxLimit, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, SerializedProperty property, Color color, Rect ranges, params GUILayoutOption[] options)
        {
            EditorGUILayout.CurveField(property, color, ranges, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, SerializedProperty property, Color color, Rect ranges, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.CurveField(property, color, ranges, label, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, SerializedProperty property, params GUILayoutOption[] options)
        {
            EditorGUILayout.DelayedIntField(property, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.DelayedIntField(property, label, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, SerializedProperty property, params GUILayoutOption[] options)
        {
            EditorGUILayout.DelayedFloatField(property, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.DelayedFloatField(property, label, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, SerializedProperty property, params GUILayoutOption[] options)
        {
            EditorGUILayout.DelayedTextField(property, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, SerializedProperty property, GUIContent label, params GUILayoutOption[] options)
        {
            EditorGUILayout.DelayedTextField(property, label, options);
            return self;
        }
        public static ILayoutGUI Vector2Field(this ILayoutGUI self, string label, ref Vector2 value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector2Field(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector3Field(this ILayoutGUI self, string label, ref Vector3 value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector3Field(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector4Field(this ILayoutGUI self, string label, ref Vector4 value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector4Field(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector2Field(this ILayoutGUI self, GUIContent label, ref Vector2 value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector2Field(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector3Field(this ILayoutGUI self, GUIContent label, ref Vector3 value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector3Field(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector4Field(this ILayoutGUI self, GUIContent label, ref Vector4 value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector4Field(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector2IntField(this ILayoutGUI self, GUIContent label, ref Vector2Int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector2IntField(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector3IntField(this ILayoutGUI self, GUIContent label, ref Vector3Int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector3IntField(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector2IntField(this ILayoutGUI self, string label, ref Vector2Int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector2IntField(label, value, options);
            return self;
        }
        public static ILayoutGUI Vector3IntField(this ILayoutGUI self, string label, ref Vector3Int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Vector3IntField(label, value, options);
            return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, string label, ref bool value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Toggle(label, value, options);
            return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, string label, ref bool value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Toggle(label, value, style, options);
            return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, GUIContent label, ref bool value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Toggle(label, value, options);
            return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, GUIContent label, ref bool value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Toggle(label, value, style, options);
            return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Toggle(value, options);
            return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Toggle(value, style, options);
            return self;
        }
        public static ILayoutGUI ToggleLeft(this ILayoutGUI self, string label, ref bool value, GUIStyle labelStyle, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
            return self;
        }
        public static ILayoutGUI ToggleLeft(this ILayoutGUI self, string label, ref bool value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ToggleLeft(label, value, options);
            return self;
        }
        public static ILayoutGUI ToggleLeft(this ILayoutGUI self, GUIContent label, ref bool value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ToggleLeft(label, value, options);
            return self;
        }
        public static ILayoutGUI ToggleLeft(this ILayoutGUI self, GUIContent label, ref bool value, GUIStyle labelStyle, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ToggleLeft(label, value, labelStyle, options);
            return self;
        }
        public static ILayoutGUI Slider(this ILayoutGUI self, GUIContent label, ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI Slider(this ILayoutGUI self, string label, ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Slider(label, value, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI Slider(this ILayoutGUI self, ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Slider(value, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI IntSlider(this ILayoutGUI self, ref int value, int leftValue, int rightValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntSlider(value, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI IntSlider(this ILayoutGUI self, string label, ref int value, int leftValue, int rightValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI IntSlider(this ILayoutGUI self, GUIContent label, ref int value, int leftValue, int rightValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntSlider(label, value, leftValue, rightValue, options);
            return self;
        }
        public static ILayoutGUI ObjectField<T>(this ILayoutGUI self, GUIContent label, ref T obj, bool allowSceneObjects, params GUILayoutOption[] options)where T:UnityEngine.Object
        {
            obj = (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
            return self;
        }
        public static ILayoutGUI ObjectField<T>(this ILayoutGUI self, ref T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
        {
            obj = (T)EditorGUILayout.ObjectField(obj, typeof(T), allowSceneObjects, options);
            return self;
        }
        public static ILayoutGUI ObjectField<T>(this ILayoutGUI self, string label, ref T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : UnityEngine.Object
        {
            obj = (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
            return self;
        }
        public static ILayoutGUI TagField(this ILayoutGUI self, ref string tag, params GUILayoutOption[] options)
        {
            tag = EditorGUILayout.TagField(tag, options);
            return self;
        }
        public static ILayoutGUI TagField(this ILayoutGUI self, ref string tag, GUIStyle style, params GUILayoutOption[] options)
        {
            tag = EditorGUILayout.TagField(tag, style, options);
            return self;
        }
        public static ILayoutGUI TagField(this ILayoutGUI self, string label, ref string tag, params GUILayoutOption[] options)
        {
            tag = EditorGUILayout.TagField(label, tag, options);
            return self;
        }
        public static ILayoutGUI TagField(this ILayoutGUI self, string label, ref string tag, GUIStyle style, params GUILayoutOption[] options)
        {
            tag = EditorGUILayout.TagField(label, tag, style, options);
            return self;
        }
        public static ILayoutGUI TagField(this ILayoutGUI self, GUIContent label, ref string tag, params GUILayoutOption[] options)
        {
            tag = EditorGUILayout.TagField(label, tag, options);
            return self;
        }
        public static ILayoutGUI TagField(this ILayoutGUI self, GUIContent label, ref string tag, GUIStyle style, params GUILayoutOption[] options)
        {
            tag = EditorGUILayout.TagField(label, tag, style, options);
            return self;
        }
        public static ILayoutGUI ETextArea(this ILayoutGUI self, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextArea(text, options);
            return self;
        }
        public static ILayoutGUI ETextArea(this ILayoutGUI self, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextArea(text, style, options);
            return self;
        }
        public static ILayoutGUI ETextField(this ILayoutGUI self, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextField(text, style, options);
            return self;
        }
        public static ILayoutGUI ETextField(this ILayoutGUI self, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextField(text, options);
            return self;
        }
        public static ILayoutGUI ETextField(this ILayoutGUI self, string label, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextField(label, text, style, options);
            return self;
        }
        public static ILayoutGUI ETextField(this ILayoutGUI self, string label, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextField(label, text, options);
            return self;
        }
        public static ILayoutGUI ETextField(this ILayoutGUI self, GUIContent label, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextField(label, text, style, options);
            return self;
        }
        public static ILayoutGUI ETextField(this ILayoutGUI self, GUIContent label, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.TextField(label, text, options);
            return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, ref string password, params GUILayoutOption[] options)
        {
            password = EditorGUILayout.PasswordField(password, options);
            return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, ref string password, GUIStyle style, params GUILayoutOption[] options)
        {
            password = EditorGUILayout.PasswordField(password, style, options);
            return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, string label, ref string password, params GUILayoutOption[] options)
        {
            password = EditorGUILayout.PasswordField(label, password, options);
            return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, string label, ref string password, GUIStyle style, params GUILayoutOption[] options)
        {
            password = EditorGUILayout.PasswordField(label, password, style, options);
            return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, GUIContent label, ref string password, params GUILayoutOption[] options)
        {
            password = EditorGUILayout.PasswordField(label, password, options);
            return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, GUIContent label, ref string password, GUIStyle style, params GUILayoutOption[] options)
        {
            password = EditorGUILayout.PasswordField(label, password, style, options);
            return self;
        }
        public static ILayoutGUI RectField(this ILayoutGUI self, GUIContent label, ref Rect value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.RectField(label, value, options);
            return self;
        }
        public static ILayoutGUI RectField(this ILayoutGUI self, string label, ref Rect value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.RectField(label, value, options);
            return self;
        }
        public static ILayoutGUI RectField(this ILayoutGUI self, ref Rect value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.RectField(value, options);
            return self;
        }
        public static ILayoutGUI RectIntField(this ILayoutGUI self, GUIContent label, ref RectInt value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.RectIntField(label, value, options);
            return self;
        }
        public static ILayoutGUI RectIntField(this ILayoutGUI self, ref RectInt value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.RectIntField(value, options);
            return self;
        }
        public static ILayoutGUI RectIntField(this ILayoutGUI self, string label, ref RectInt value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.RectIntField(label, value, options);
            return self;
        }
        public static ILayoutGUI LayerField(this ILayoutGUI self, GUIContent label, ref int layer, GUIStyle style, params GUILayoutOption[] options)
        {
            layer = EditorGUILayout.LayerField(label, layer, style, options);
            return self;
        }
        public static ILayoutGUI LayerField(this ILayoutGUI self, GUIContent label, ref int layer, params GUILayoutOption[] options)
        {
            layer = EditorGUILayout.LayerField(label, layer, options);
            return self;
        }
        public static ILayoutGUI LayerField(this ILayoutGUI self, string label, ref int layer, GUIStyle style, params GUILayoutOption[] options)
        {
            layer = EditorGUILayout.LayerField(label, layer, style, options);
            return self;
        }
        public static ILayoutGUI LayerField(this ILayoutGUI self, string label, ref int layer, params GUILayoutOption[] options)
        {
            layer = EditorGUILayout.LayerField(label, layer, options);
            return self;
        }
        public static ILayoutGUI LayerField(this ILayoutGUI self, ref int layer, GUIStyle style, params GUILayoutOption[] options)
        {
            layer = EditorGUILayout.LayerField(layer, style, options);
            return self;
        }
        public static ILayoutGUI LayerField(this ILayoutGUI self, ref int layer, params GUILayoutOption[] options)
        {
            layer = EditorGUILayout.LayerField(layer, options);
            return self;
        }
        public static ILayoutGUI MaskField(this ILayoutGUI self, ref int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            mask = EditorGUILayout.MaskField(mask, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI MaskField(this ILayoutGUI self, ref int mask, string[] displayedOptions, params GUILayoutOption[] options)
        {
            mask = EditorGUILayout.MaskField(mask, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI MaskField(this ILayoutGUI self, string label, ref int mask, string[] displayedOptions, params GUILayoutOption[] options)
        {
            mask = EditorGUILayout.MaskField(label, mask, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI MaskField(this ILayoutGUI self, string label, ref int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            mask = EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI MaskField(this ILayoutGUI self, GUIContent label, ref int mask, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            mask = EditorGUILayout.MaskField(label, mask, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI MaskField(this ILayoutGUI self, GUIContent label, ref int mask, string[] displayedOptions, params GUILayoutOption[] options)
        {
            mask = EditorGUILayout.MaskField(label, mask, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI IntField(this ILayoutGUI self, GUIContent label, ref int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntField(label, value, options);
            return self;
        }
        public static ILayoutGUI IntField(this ILayoutGUI self, GUIContent label, ref int value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI IntField(this ILayoutGUI self, ref int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntField(value, options);
            return self;
        }
        public static ILayoutGUI IntField(this ILayoutGUI self, ref int value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntField(value, style, options);
            return self;
        }
        public static ILayoutGUI IntField(this ILayoutGUI self, string label, ref int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntField(label, value, options);
            return self;
        }
        public static ILayoutGUI IntField(this ILayoutGUI self, string label, ref int value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.IntField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI LongField(this ILayoutGUI self, ref long value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.LongField(value, style, options);
            return self;
        }
        public static ILayoutGUI LongField(this ILayoutGUI self, ref long value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.LongField(value, options);
            return self;
        }
        public static ILayoutGUI LongField(this ILayoutGUI self, string label, ref long value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.LongField(label, value, options);
            return self;
        }
        public static ILayoutGUI LongField(this ILayoutGUI self, string label, ref long value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.LongField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI LongField(this ILayoutGUI self, GUIContent label, ref long value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.LongField(label, value, options);
            return self;
        }
        public static ILayoutGUI LongField(this ILayoutGUI self, GUIContent label, ref long value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.LongField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI FloatField(this ILayoutGUI self, ref float value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.FloatField(value, options);
            return self;
        }
        public static ILayoutGUI FloatField(this ILayoutGUI self, ref float value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.FloatField(value, style, options);
            return self;
        }
        public static ILayoutGUI FloatField(this ILayoutGUI self, string label, ref float value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.FloatField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DoubleField(this ILayoutGUI self, ref double value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DoubleField(value, options);
            return self;
        }
        public static ILayoutGUI DoubleField(this ILayoutGUI self, ref double value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DoubleField(value, style, options);
            return self;
        }
        public static ILayoutGUI DoubleField(this ILayoutGUI self, string label, ref double value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DoubleField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DoubleField(this ILayoutGUI self, string label, ref double value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DoubleField(label, value, options);
            return self;
        }
        public static ILayoutGUI DoubleField(this ILayoutGUI self, GUIContent label, ref double value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DoubleField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DoubleField(this ILayoutGUI self, GUIContent label, ref double value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DoubleField(label, value, options);
            return self;
        }
        public static ILayoutGUI BoundsField(this ILayoutGUI self, string label, ref Bounds value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.BoundsField(label, value, options);
            return self;
        }
        public static ILayoutGUI BoundsField(this ILayoutGUI self, ref Bounds value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.BoundsField(value, options);
            return self;
        }
        public static ILayoutGUI BoundsField(this ILayoutGUI self, GUIContent label, ref Bounds value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.BoundsField(label, value, options);
            return self;
        }
        public static ILayoutGUI BoundsIntField(this ILayoutGUI self, string label, ref BoundsInt value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.BoundsIntField(label, value, options);
            return self;
        }
        public static ILayoutGUI BoundsIntField(this ILayoutGUI self, GUIContent label, ref BoundsInt value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.BoundsIntField(label, value, options);
            return self;
        }
        public static ILayoutGUI BoundsIntField(this ILayoutGUI self, ref BoundsInt value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.BoundsIntField(value, options);
            return self;
        }
        public static ILayoutGUI ColorField(this ILayoutGUI self, ref Color value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ColorField(value, options);
            return self;
        }
        public static ILayoutGUI ColorField(this ILayoutGUI self, string label, ref Color value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ColorField(label, value, options);
            return self;
        }
        public static ILayoutGUI ColorField(this ILayoutGUI self, GUIContent label, ref Color value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.ColorField(label, value, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, ref AnimationCurve value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.CurveField(value, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, ref AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.CurveField(value, color, ranges, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, string label, ref AnimationCurve value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.CurveField(label, value, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, string label, ref AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.CurveField(label, value, color, ranges, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, GUIContent label, ref AnimationCurve value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.CurveField(label, value, options);
            return self;
        }
        public static ILayoutGUI CurveField(this ILayoutGUI self, GUIContent label, ref AnimationCurve value, Color color, Rect ranges, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.CurveField(label, value, color, ranges, options);
            return self;
        }
        public static ILayoutGUI FloatField(this ILayoutGUI self, string label, ref float value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.FloatField(label, value, options);
            return self;
        }
        public static ILayoutGUI FloatField(this ILayoutGUI self, GUIContent label, ref float value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.FloatField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI FloatField(this ILayoutGUI self, GUIContent label, ref float value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.FloatField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, string label, ref int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedIntField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, string label, ref int value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedIntField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, GUIContent label, ref int value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedIntField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, GUIContent label, ref int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedIntField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, ref int value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedIntField(value, options);
            return self;
        }
        public static ILayoutGUI DelayedIntField(this ILayoutGUI self, ref int value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedIntField(value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, ref float value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedFloatField(value, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, ref float value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedFloatField(value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, string label, ref float value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedFloatField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, string label, ref float value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedFloatField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, GUIContent label, ref float value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedFloatField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedFloatField(this ILayoutGUI self, GUIContent label, ref float value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedFloatField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedDoubleField(this ILayoutGUI self, ref double value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedDoubleField(value, options);
            return self;
        }
        public static ILayoutGUI DelayedDoubleField(this ILayoutGUI self, ref double value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedDoubleField(value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedDoubleField(this ILayoutGUI self, ref string label, double value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedDoubleField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedDoubleField(this ILayoutGUI self, ref string label, double value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedDoubleField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedDoubleField(this ILayoutGUI self, GUIContent label, ref double value, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedDoubleField(label, value, options);
            return self;
        }
        public static ILayoutGUI DelayedDoubleField(this ILayoutGUI self, GUIContent label, ref double value, GUIStyle style, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.DelayedDoubleField(label, value, style, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.DelayedTextField(text, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.DelayedTextField(text, style, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, string label, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.DelayedTextField(label, text, style, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, string label, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.DelayedTextField(label, text, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, GUIContent label, ref string text, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.DelayedTextField(label, text, options);
            return self;
        }
        public static ILayoutGUI DelayedTextField(this ILayoutGUI self, GUIContent label, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = EditorGUILayout.DelayedTextField(label, text, style, options);
            return self;
        }
#if !UNITY_2017_3_OR_NEWER
        public static ILayoutGUIDrawer EnumMaskPopup(this ILayoutGUIDrawer self,string label,ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
        {
            selected= EditorGUILayout.EnumMaskPopup(label, selected, style, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskPopup(this ILayoutGUIDrawer self,string label,ref Enum selected, params GUILayoutOption[] options)
        {
            selected = EditorGUILayout.EnumMaskPopup(label, selected, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskField(this ILayoutGUIDrawer self,string label,ref Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
        {
            enumValue = EditorGUILayout.EnumMaskField(label, enumValue, style, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskField(this ILayoutGUIDrawer self,string label,ref Enum enumValue, params GUILayoutOption[] options)
        {
            enumValue = EditorGUILayout.EnumMaskField(label, enumValue, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskPopup(this ILayoutGUIDrawer self,GUIContent label,ref Enum selected, params GUILayoutOption[] options)
        {
            selected = EditorGUILayout.EnumMaskPopup(label, selected, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskPopup(this ILayoutGUIDrawer self,GUIContent label,ref Enum selected, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = EditorGUILayout.EnumMaskPopup(label, selected, style, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskField(this ILayoutGUIDrawer self,GUIContent label,ref Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
        {
            enumValue = EditorGUILayout.EnumMaskField(label, enumValue, style, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskField(this ILayoutGUIDrawer self,GUIContent label,ref Enum enumValue, params GUILayoutOption[] options)
        {
            enumValue = EditorGUILayout.EnumMaskField(label, enumValue, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskField(this ILayoutGUIDrawer self,ref Enum enumValue, params GUILayoutOption[] options)
        {
            enumValue = EditorGUILayout.EnumMaskField(enumValue, options);
            return self;
        }
        public static ILayoutGUIDrawer EnumMaskField(this ILayoutGUIDrawer self,ref Enum enumValue, GUIStyle style, params GUILayoutOption[] options)
        {
            enumValue = EditorGUILayout.EnumMaskField(enumValue, style, options);
            return self;
        }
#endif
        public static ILayoutGUI Knob(this ILayoutGUI self, Vector2 knobSize, ref float value, float minValue, float maxValue, string unit, Color backgroundColor, Color activeColor, bool showValue, params GUILayoutOption[] options)
        {
            value = EditorGUILayout.Knob(knobSize, value, minValue, maxValue, unit, backgroundColor, activeColor, showValue, options);
            return self;
        }
        public static ILayoutGUI InspectorTitlebar(this ILayoutGUI self, ref bool foldout, UnityEngine.Object targetObj)
        {
            foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObj);
            return self;
        }
        public static ILayoutGUI InspectorTitlebar(this ILayoutGUI self, ref bool foldout, UnityEngine.Object[] targetObjs, bool expandable)
        {
            foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObjs, expandable);
            return self;
        }
        public static ILayoutGUI InspectorTitlebar(this ILayoutGUI self, ref bool foldout, UnityEngine.Object[] targetObjs)
        {
            foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObjs);
            return self;
        }
        public static ILayoutGUI InspectorTitlebar(this ILayoutGUI self, ref bool foldout, UnityEngine.Object targetObj, bool expandable)
        {
            foldout = EditorGUILayout.InspectorTitlebar(foldout, targetObj, expandable);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, ref int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, ref int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, ref int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, ref int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, string label, ref int selectedIndex, string[] displayedOptions, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, string label, ref int selectedIndex, string[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, GUIContent label, ref int selectedIndex, GUIContent[] displayedOptions, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(selectedIndex, displayedOptions, options);
            return self;
        }
        public static ILayoutGUI Popup(this ILayoutGUI self, GUIContent label, ref int selectedIndex, GUIContent[] displayedOptions, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedIndex = EditorGUILayout.Popup(label, selectedIndex, displayedOptions, style, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, ref int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, ref int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, GUIContent label, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, GUIContent label, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(selectedValue, displayedOptions, optionValues, style, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, string label, ref int selectedValue, string[] displayedOptions, int[] optionValues, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, options);
            return self;
        }
        public static ILayoutGUI IntPopup(this ILayoutGUI self, string label, ref int selectedValue, string[] displayedOptions, int[] optionValues, GUIStyle style, params GUILayoutOption[] options)
        {
            selectedValue = EditorGUILayout.IntPopup(label, selectedValue, displayedOptions, optionValues, style, options);
            return self;
        }
#if NET_4_6
        public static ILayoutGUI EnumPopup<T>(this ILayoutGUI self, GUIContent label, ref T selected, GUIStyle style, params GUILayoutOption[] options)where T:Enum
        {
            selected = (T)EditorGUILayout.EnumPopup(label, selected, style, options);
            return self;
        }
        public static ILayoutGUI EnumPopup<T>(this ILayoutGUI self, GUIContent label, ref T selected, params GUILayoutOption[] options) where T : Enum
        {
            selected = (T)EditorGUILayout.EnumPopup(label, selected, options);
            return self;
        }
        public static ILayoutGUI EnumPopup<T>(this ILayoutGUI self, ref T selected, GUIStyle style, params GUILayoutOption[] options) where T : Enum
        {
            selected = (T)EditorGUILayout.EnumPopup(selected, style, options);
            return self;
        }
        public static ILayoutGUI EnumPopup<T>(this ILayoutGUI self, ref T selected, params GUILayoutOption[] options) where T : Enum
        {
            selected = (T)EditorGUILayout.EnumPopup(selected, options);
            return self;
        }
        public static ILayoutGUI EnumPopup<T>(this ILayoutGUI self, string label, ref T selected, GUIStyle style, params GUILayoutOption[] options) where T : Enum
        {
            selected = (T)EditorGUILayout.EnumPopup(label, selected, style, options);
            return self;
        }
        public static ILayoutGUI EnumPopup<T>(this ILayoutGUI self, string label, ref T selected, params GUILayoutOption[] options) where T : Enum
        {
            selected = (T)EditorGUILayout.EnumPopup(label, selected, options);
            return self;
        }
#endif
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, string content, bool toggleOnLabelClick)
        {
            foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, string content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, GUIContent content, bool toggleOnLabelClick)
        {
            foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, GUIContent content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUILayout.Foldout(foldout, content, toggleOnLabelClick, style);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUILayout.Foldout(foldout, content, style);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, GUIContent content)
        {
            foldout = EditorGUILayout.Foldout(foldout, content);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, string content)
        {
            foldout = EditorGUILayout.Foldout(foldout, content);
            return self;
        }
        public static ILayoutGUI Foldout(this ILayoutGUI self, ref bool foldout, string content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUILayout.Foldout(foldout, content, style);
            return self;
        }
        public static ILayoutGUI EDrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
            if (draw != null) draw();
            EditorGUILayout.EndScrollView();
            return self;
        }
        public static ILayoutGUI EDrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, style, options);
            if (draw != null) draw();
            EditorGUILayout.EndScrollView();
            return self;
        }
        public static ILayoutGUI EDrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
            if (draw != null) draw();
            EditorGUILayout.EndScrollView();
            return self;
        }
        public static ILayoutGUI EDrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
            if (draw != null) draw();
            EditorGUILayout.EndScrollView();
            return self;
        }
        public static ILayoutGUI EDrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPosition, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, options);
            if (draw != null) draw();
            EditorGUILayout.EndScrollView();
            return self;

        }
        public static ILayoutGUI EDrawToggleGroup(this ILayoutGUI self, Action draw, string label, ref bool toggle)
        {
            toggle = EditorGUILayout.BeginToggleGroup(label, toggle);
            if (draw != null) draw();
            EditorGUILayout.EndToggleGroup();
            return self;
        }
        public static ILayoutGUI EDrawToggleGroup(this ILayoutGUI self, Action draw, GUIContent label, ref bool toggle)
        {
            toggle = EditorGUILayout.BeginToggleGroup(label, toggle);
            if (draw != null) draw();
            EditorGUILayout.EndToggleGroup();
            return self;
        }
                                      
                                      
        public static ILayoutGUI EBeginScrollView(this ILayoutGUI self, ref Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
            return self;
        }
        public static ILayoutGUI EBeginScrollView(this ILayoutGUI self, ref Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, style, options);
            return self;

        }
        public static ILayoutGUI EBeginScrollView(this ILayoutGUI self, ref Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
            return self;

        }
        public static ILayoutGUI EBeginScrollView(this ILayoutGUI self, ref Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
            return self;
        }
        public static ILayoutGUI EBeginScrollView(this ILayoutGUI self, ref Vector2 scrollPosition, params GUILayoutOption[] options)
        {
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, options);
            return self;
        }
        public static ILayoutGUI EEndScrollView(this ILayoutGUI self)
        {
            EditorGUILayout.EndScrollView();
            return self;
        }
        public static ILayoutGUI EBeginVertical(this ILayoutGUI self, out Rect rect, params GUILayoutOption[] options)
        {
            rect = EditorGUILayout.BeginVertical(options);
            return self;
        }
        public static ILayoutGUI EBeginVertical(this ILayoutGUI self, out Rect rect, GUIStyle style, params GUILayoutOption[] options)
        {
            rect = EditorGUILayout.BeginVertical(style, options);
            return self;
        }
        public static ILayoutGUI EEndVertical(this ILayoutGUI self)
        {
            EditorGUILayout.EndVertical();
            return self;
        }
        public static ILayoutGUI EBeginHorizontal(this ILayoutGUI self, out Rect rect, params GUILayoutOption[] options)
        {
            rect = EditorGUILayout.BeginHorizontal(options);
            return self;
        }
        public static ILayoutGUI EBeginHorizontal(this ILayoutGUI self, out Rect rect, GUIStyle style, params GUILayoutOption[] options)
        {
            rect = EditorGUILayout.BeginHorizontal(style, options);
            return self;
        }
        public static ILayoutGUI EEndHorizontal(this ILayoutGUI self)
        {
            EditorGUILayout.EndVertical();
            return self;
        }
        public static ILayoutGUI EBeginFadeGroup(this ILayoutGUI self, float value, out bool bo)
        {
            bo = EditorGUILayout.BeginFadeGroup(value);
            return self;
        }
        public static ILayoutGUI EEndFadeGroup(this ILayoutGUI self)
        {
            EditorGUILayout.EndFadeGroup();
            return self;
        }
        public static ILayoutGUI EBeginToggleGroup(this ILayoutGUI self, string label, ref bool toggle)
        {
            toggle = EditorGUILayout.BeginToggleGroup(label, toggle);

            return self;
        }
        public static ILayoutGUI EBeginToggleGroup(this ILayoutGUI self, GUIContent label, ref bool toggle)
        {
            toggle = EditorGUILayout.BeginToggleGroup(label, toggle);
            return self;
        }
        public static ILayoutGUI EEndToggleGroup(this ILayoutGUI self, GUIContent label, ref bool toggle)
        {
            EditorGUILayout.EndToggleGroup();
            return self;
        }
    }
}
