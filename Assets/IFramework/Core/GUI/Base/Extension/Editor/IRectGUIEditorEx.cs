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
    public static partial class IRectGUIEditorEx
    {
        public static IRectGUI ChangeCheck(this IRectGUI self, Action act)
        {
            EditorGUI.BeginChangeCheck();
            if (act != null) act();
            EditorGUI.EndChangeCheck();
            return self;
        }
        public static IRectGUI DrawDisabledGroup(this IRectGUI self, Action act, bool disabled)
        {
            EditorGUI.BeginDisabledGroup(disabled);
            if (act != null) act();
            EditorGUI.EndDisabledGroup(); return self;

        }
        public static IRectGUI FocusTextInControl(this IRectGUI self, string name)
        {
            EditorGUI.FocusTextInControl(name); return self;

        }
        public static IRectGUI HelpBox(this IRectGUI self, Rect position, string message, UnityEditor.MessageType type)
        {
            EditorGUI.HelpBox(position, message, type); return self;

        }
        public static IRectGUI DropShadowLabel(this IRectGUI self, Rect position, string text)
        {
            EditorGUI.DropShadowLabel(position, text); return self;

        }
        public static IRectGUI DropShadowLabel(this IRectGUI self, Rect position, GUIContent content)
        {
            EditorGUI.DropShadowLabel(position, content); return self;

        }
        public static IRectGUI DropShadowLabel(this IRectGUI self, Rect position, string text, GUIStyle style)
        {
            EditorGUI.DropShadowLabel(position, text, style); return self;

        }
        public static IRectGUI DropShadowLabel(this IRectGUI self, Rect position, GUIContent content, GUIStyle style)
        {
            EditorGUI.DropShadowLabel(position, content, style); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, GUIContent label, GUIContent label2, [DefaultValue("EditorStyles.label")] GUIStyle style)
        {
            EditorGUI.LabelField(position, label, label2, style); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, string label)
        {
            EditorGUI.LabelField(position, label); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, string label, [DefaultValue("EditorStyles.label")] GUIStyle style)
        {
            EditorGUI.LabelField(position, label, style); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, GUIContent label)
        {
            EditorGUI.LabelField(position, label); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, GUIContent label, [DefaultValue("EditorStyles.label")] GUIStyle style)
        {
            EditorGUI.LabelField(position, label, style); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, string label, string label2)
        {
            EditorGUI.LabelField(position, label, label2); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, GUIContent label, GUIContent label2)
        {
            EditorGUI.LabelField(position, label, label2); return self;

        }
        public static IRectGUI LabelField(this IRectGUI self, Rect position, string label, string label2, [DefaultValue("EditorStyles.label")] GUIStyle style)
        {
            EditorGUI.LabelField(position, label, label2, style); return self;

        }
        public static IRectGUI SelectableLabel(this IRectGUI self, Rect position, string text, [DefaultValue("EditorStyles.label")] GUIStyle style)
        {
            EditorGUI.SelectableLabel(position, text, style); return self;

        }
        public static IRectGUI SelectableLabel(this IRectGUI self, Rect position, string text)
        {
            EditorGUI.SelectableLabel(position, text); return self;

        }
        public static IRectGUI HandlePrefixLabel(this IRectGUI self, Rect totalPosition, Rect labelPosition, GUIContent label, int id)
        {
            EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label, id); return self;

        }
        public static IRectGUI HandlePrefixLabel(this IRectGUI self, Rect totalPosition, Rect labelPosition, GUIContent label, [DefaultValue("0")] int id, [DefaultValue("EditorStyles.label")] GUIStyle style)
        {
            EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label, id, style); return self;

        }
        public static IRectGUI HandlePrefixLabel(this IRectGUI self, Rect totalPosition, Rect labelPosition, GUIContent label)
        {
            EditorGUI.HandlePrefixLabel(totalPosition, labelPosition, label); return self;

        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, SerializedProperty property, [DefaultValue("null")] GUIContent label)
        {
            EditorGUI.DelayedTextField(position, property, label); return self;

        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, SerializedProperty property)
        {
            EditorGUI.DelayedTextField(position, property); return self;

        }
        public static IRectGUI IntSlider(this IRectGUI self, Rect position, SerializedProperty property, int leftValue, int rightValue)
        {
            EditorGUI.IntSlider(position, property, leftValue, rightValue); return self;

        }
        public static IRectGUI IntSlider(this IRectGUI self, Rect position, SerializedProperty property, int leftValue, int rightValue, string label)
        {
            EditorGUI.IntSlider(position, property, leftValue, rightValue, label); return self;

        }
        public static IRectGUI IntSlider(this IRectGUI self, Rect position, SerializedProperty property, int leftValue, int rightValue, GUIContent label)
        {
            EditorGUI.IntSlider(position, property, leftValue, rightValue, label); return self;

        }
        public static IRectGUI MinMaxSlider(this IRectGUI self, Rect position, ref float minValue, ref float maxValue, float minLimit, float maxLimit)
        {
            EditorGUI.MinMaxSlider(position, ref minValue, ref maxValue, minLimit, maxLimit); return self;

        }
        public static IRectGUI MinMaxSlider(this IRectGUI self, Rect position, string label, ref float minValue, ref float maxValue, float minLimit, float maxLimit)
        {
            EditorGUI.MinMaxSlider(position, ref minValue, ref maxValue, minLimit, maxLimit); return self;

        }
        public static IRectGUI Slider(this IRectGUI self, Rect position, SerializedProperty property, float leftValue, float rightValue)
        {
            EditorGUI.Slider(position, property, leftValue, rightValue); return self;

        }
        public static IRectGUI Slider(this IRectGUI self, Rect position, SerializedProperty property, float leftValue, float rightValue, string label)
        {
            EditorGUI.Slider(position, property, leftValue, rightValue, label); return self;

        }
        public static IRectGUI Slider(this IRectGUI self, Rect position, SerializedProperty property, float leftValue, float rightValue, GUIContent label)
        {
            EditorGUI.Slider(position, property, leftValue, rightValue, label); return self;

        }
        public static IRectGUI InspectorTitlebar(this IRectGUI self, Rect position, UnityEngine.Object[] targetObjs)
        {
            EditorGUI.InspectorTitlebar(position, targetObjs); return self;

        }
        public static IRectGUI DrawPreviewTexture(this IRectGUI self, Rect position, Texture image, [DefaultValue("null")] Material mat, [DefaultValue("ScaleMode.StretchToFill")] ScaleMode scaleMode, [DefaultValue("0")] float imageAspect)
        {
            EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode, imageAspect); return self;

        }
        public static IRectGUI DrawPreviewTexture(this IRectGUI self, Rect position, Texture image)
        {
            EditorGUI.DrawPreviewTexture(position, image); return self;

        }
        public static IRectGUI DrawPreviewTexture(this IRectGUI self, Rect position, Texture image, Material mat)
        {
            EditorGUI.DrawPreviewTexture(position, image, mat); return self;

        }
        public static IRectGUI DrawPreviewTexture(this IRectGUI self, Rect position, Texture image, Material mat, ScaleMode scaleMode)
        {
            EditorGUI.DrawPreviewTexture(position, image, mat, scaleMode); return self;

        }
        public static IRectGUI DrawTextureAlpha(this IRectGUI self, Rect position, Texture image, [DefaultValue("ScaleMode.StretchToFill")] ScaleMode scaleMode, [DefaultValue("0")] float imageAspect)
        {
            EditorGUI.DrawTextureAlpha(position, image, scaleMode, imageAspect); return self;

        }
        public static IRectGUI DrawTextureAlpha(this IRectGUI self, Rect position, Texture image)
        {
            EditorGUI.DrawTextureAlpha(position, image); return self;

        }
        public static IRectGUI DrawTextureAlpha(this IRectGUI self, Rect position, Texture image, ScaleMode scaleMode)
        {
            EditorGUI.DrawTextureAlpha(position, image, scaleMode); return self;

        }
        public static IRectGUI DrawRect(this IRectGUI self, Rect rect, Color color)
        {
            EditorGUI.DrawRect(rect, color);
            return self;
        }
        public static IRectGUI DrawTextureTransparent(this IRectGUI self, Rect position, Texture image, [DefaultValue("ScaleMode.StretchToFill")] ScaleMode scaleMode, [DefaultValue("0")] float imageAspect)
        {
            EditorGUI.DrawTextureTransparent(position, image, scaleMode, imageAspect);
            return self;
        }
        public static IRectGUI DrawTextureTransparent(this IRectGUI self, Rect position, Texture image)
        {
            EditorGUI.DrawTextureTransparent(position, image);
            return self;
        }
        public static IRectGUI DrawTextureTransparent(this IRectGUI self, Rect position, Texture image, ScaleMode scaleMode)
        {
            EditorGUI.DrawTextureTransparent(position, image, scaleMode);
            return self;
        }
        public static IRectGUI ProgressBar(this IRectGUI self, Rect position, float value, string text)
        {
            EditorGUI.ProgressBar(position, value, text);
            return self;
        }
        public static IRectGUI DropdownButton(this IRectGUI self, Action<bool> act, Rect position, GUIContent content, FocusType focusType, GUIStyle style)
        {
            if (act == null)
            {
                EditorGUI.DropdownButton(position, content, focusType, style);
            }
            else
            {
                act(EditorGUI.DropdownButton(position, content, focusType, style));
            }
            return self;
        }
        public static IRectGUI DropdownButton(this IRectGUI self, Action<bool> act, Rect position, GUIContent content, FocusType focusType)
        {
            if (act == null)
            {
                EditorGUI.DropdownButton(position, content, focusType);
            }
            else
            {
                act(EditorGUI.DropdownButton(position, content, focusType));
            }
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues)
        {
            EditorGUI.IntPopup(position, property, displayedOptions, optionValues);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, SerializedProperty property, GUIContent[] displayedOptions, int[] optionValues, [DefaultValue("null")] GUIContent label)
        {
            EditorGUI.IntPopup(position, property, displayedOptions, optionValues, label);
            return self;
        }
        public static IRectGUI MultiFloatField(this IRectGUI self, Rect position, GUIContent label, GUIContent[] subLabels, float[] values)
        {
            EditorGUI.MultiFloatField(position, label, subLabels, values);
            return self;
        }
        public static IRectGUI MultiFloatField(this IRectGUI self, Rect position, GUIContent[] subLabels, float[] values)
        {
            EditorGUI.MultiFloatField(position, subLabels, values);
            return self;
        }
        public static IRectGUI ObjectField(this IRectGUI self, Rect position, SerializedProperty property)
        {
            EditorGUI.ObjectField(position, property);
            return self;
        }
        public static IRectGUI ObjectField(this IRectGUI self, Rect position, SerializedProperty property, Type objType, GUIContent label)
        {
            EditorGUI.ObjectField(position, property, objType, label);
            return self;
        }
        public static IRectGUI ObjectField(this IRectGUI self, Rect position, SerializedProperty property, Type objType)
        {
            EditorGUI.ObjectField(position, property, objType);
            return self;
        }
        public static IRectGUI ObjectField(this IRectGUI self, Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.ObjectField(position, property, label);
            return self;
        }
        public static IRectGUI MultiPropertyField(this IRectGUI self, Rect position, GUIContent[] subLabels, SerializedProperty valuesIterator)
        {
            EditorGUI.MultiPropertyField(position, subLabels, valuesIterator);
            return self;
        }
        public static IRectGUI MultiPropertyField(this IRectGUI self, Rect position, GUIContent[] subLabels, SerializedProperty valuesIterator, GUIContent label)
        {
            EditorGUI.MultiPropertyField(position, subLabels, valuesIterator, label);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, SerializedProperty property, [DefaultValue("null")] GUIContent label)
        {
            EditorGUI.DelayedIntField(position, property, label);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, SerializedProperty property)
        {
            EditorGUI.DelayedIntField(position, property);
            return self;
        }
        public static IRectGUI MultiIntField(this IRectGUI self, Rect position, GUIContent[] subLabels, int[] values)
        {
            EditorGUI.MultiIntField(position, subLabels, values);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, SerializedProperty property)
        {
            EditorGUI.DelayedFloatField(position, property);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, SerializedProperty property, [DefaultValue("null")] GUIContent label)
        {
            EditorGUI.DelayedFloatField(position, property, label);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, SerializedProperty property, Color color, Rect ranges)
        {
            EditorGUI.CurveField(position, property, color, ranges);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, SerializedProperty property, Color color, Rect ranges, GUIContent label)
        {
            EditorGUI.CurveField(position, property, color, ranges, label);
            return self;
        }
        public static IRectGUI rawProperty(this IRectGUI self, Action act, Rect totalPosition, ref GUIContent label, SerializedProperty property)
        {
            label = EditorGUI.BeginProperty(totalPosition, label, property);
            if (act != null) act();
            EditorGUI.EndProperty();
            return self;
        }
        public static IRectGUI IndentedRect(this IRectGUI self, ref Rect source)
        {
            source = EditorGUI.IndentedRect(source);
            return self;
        }
        public static IRectGUI PrefixLabel(this IRectGUI self, ref Rect totalPosition, int id, GUIContent label, GUIStyle style)
        {
            totalPosition = EditorGUI.PrefixLabel(totalPosition, id, label, style);
            return self;
        }
        public static IRectGUI PrefixLabel(this IRectGUI self, ref Rect totalPosition, GUIContent label, GUIStyle style)
        {
            totalPosition = EditorGUI.PrefixLabel(totalPosition, label, style);
            return self;
        }
        public static IRectGUI PrefixLabel(this IRectGUI self, ref Rect totalPosition, int id, GUIContent label)
        {
            totalPosition = EditorGUI.PrefixLabel(totalPosition, id, label);
            return self;
        }
        public static IRectGUI PrefixLabel(this IRectGUI self, ref Rect totalPosition, GUIContent label)
        {
            totalPosition = EditorGUI.PrefixLabel(totalPosition, label);
            return self;
        }
        public static IRectGUI TagField(this IRectGUI self, Rect position, ref string tag)
        {
            tag = EditorGUI.TagField(position, tag);
            return self;
        }
        public static IRectGUI TagField(this IRectGUI self, Rect position, ref string tag, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            tag = EditorGUI.TagField(position, tag, style);
            return self;
        }
        public static IRectGUI TagField(this IRectGUI self, Rect position, string label, ref string tag)
        {
            tag = EditorGUI.TagField(position, label, tag);
            return self;
        }
        public static IRectGUI TagField(this IRectGUI self, Rect position, string label, ref string tag, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            tag = EditorGUI.TagField(position, label, tag, style);
            return self;
        }
        public static IRectGUI TagField(this IRectGUI self, Rect position, GUIContent label, ref string tag)
        {
            tag = EditorGUI.TagField(position, label, tag);
            return self;
        }
        public static IRectGUI TagField(this IRectGUI self, Rect position, GUIContent label, ref string tag, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            tag = EditorGUI.TagField(position, label, tag, style);
            return self;
        }
        public static IRectGUI ETextArea(this IRectGUI self, Rect position, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.TextArea(position, text, style);
            return self;
        }
        public static IRectGUI ETextArea(this IRectGUI self, Rect position, ref string text)
        {
            text = EditorGUI.TextArea(position, text);
            return self;
        }
        public static IRectGUI ETextField(this IRectGUI self, Rect position, GUIContent label, ref string text)
        {
            text = EditorGUI.TextField(position, label, text);
            return self;
        }
        public static IRectGUI ETextField(this IRectGUI self, Rect position, string label, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.TextField(position, label, text, style);
            return self;
        }
        public static IRectGUI ETextField(this IRectGUI self, Rect position, string label, ref string text)
        {
            text = EditorGUI.TextField(position, label, text);
            return self;
        }
        public static IRectGUI ETextField(this IRectGUI self, Rect position, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.TextField(position, text, style);
            return self;
        }
        public static IRectGUI ETextField(this IRectGUI self, Rect position, ref string text)
        {
            text = EditorGUI.TextField(position, text);
            return self;
        }
        public static IRectGUI ETextField(this IRectGUI self, Rect position, GUIContent label, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.TextField(position, label, text, style);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, GUIContent label, int controlId, ref string text)
        {
            text = EditorGUI.DelayedTextField(position, label, controlId, text);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, GUIContent label, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.DelayedTextField(position, label, text, style);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, GUIContent label, ref string text)
        {
            text = EditorGUI.DelayedTextField(position, label, text);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, GUIContent label, int controlId, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.DelayedTextField(position, label, controlId, text, style);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, string label, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.DelayedTextField(position, label, text, style);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, ref string text)
        {
            text = EditorGUI.DelayedTextField(position, text);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, string label, ref string text)
        {
            text = EditorGUI.DelayedTextField(position, label, text);
            return self;
        }
        public static IRectGUI DelayedTextField(this IRectGUI self, Rect position, ref string text, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            text = EditorGUI.DelayedTextField(position, text, style);
            return self;
        }
        public static IRectGUI PasswordField(this IRectGUI self, Rect position, GUIContent label, ref string password)
        {
            password = EditorGUI.PasswordField(position, label, password);
            return self;

        }
        public static IRectGUI PasswordField(this IRectGUI self, Rect position, string label, ref string password, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            password = EditorGUI.PasswordField(position, label, password, style);
            return self;
        }
        public static IRectGUI PasswordField(this IRectGUI self, Rect position, string label, ref string password)
        {
            password = EditorGUI.PasswordField(position, label, password);
            return self;
        }
        public static IRectGUI PasswordField(this IRectGUI self, Rect position, ref string password, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            password = EditorGUI.PasswordField(position, password, style);
            return self;
        }
        public static IRectGUI PasswordField(this IRectGUI self, Rect position, ref string password)
        {
            password = EditorGUI.PasswordField(position, password);
            return self;
        }
        public static IRectGUI PasswordField(this IRectGUI self, Rect position, GUIContent label, ref string password, [DefaultValue("EditorStyles.textField")] GUIStyle style)
        {
            password = EditorGUI.PasswordField(position, label, password, style);
            return self;
        }
        public static IRectGUI BoundsField(this IRectGUI self, Rect position, ref Bounds value)
        {
            value = EditorGUI.BoundsField(position, value);
            return self;
        }
        public static IRectGUI BoundsField(this IRectGUI self, Rect position, GUIContent label, ref Bounds value)
        {
            value = EditorGUI.BoundsField(position, label, value);
            return self;
        }
        public static IRectGUI BoundsField(this IRectGUI self, Rect position, string label, ref Bounds value)
        {
            value = EditorGUI.BoundsField(position, label, value);
            return self;
        }
        public static IRectGUI BoundsIntField(this IRectGUI self, Rect position, ref BoundsInt value)
        {
            value = EditorGUI.BoundsIntField(position, value);
            return self;
        }
        public static IRectGUI BoundsIntField(this IRectGUI self, Rect position, string label, ref BoundsInt value)
        {
            value = EditorGUI.BoundsIntField(position, label, value);
            return self;
        }
        public static IRectGUI BoundsIntField(this IRectGUI self, Rect position, GUIContent label, ref BoundsInt value)
        {
            value = EditorGUI.BoundsIntField(position, label, value);
            return self;
        }
        public static IRectGUI ColorField(this IRectGUI self, Rect position, GUIContent label, ref Color value)
        {
            value = EditorGUI.ColorField(position, label, value);
            return self;
        }
        public static IRectGUI ColorField(this IRectGUI self, Rect position, ref Color value)
        {
            value = EditorGUI.ColorField(position, value);
            return self;
        }
                                    
        public static IRectGUI ColorField(this IRectGUI self, Rect position, string label, ref Color value)
        {
            value = EditorGUI.ColorField(position, label, value);
            return self;
        }
        public static IRectGUI RectField(this IRectGUI self, Rect position, GUIContent label, ref Rect value)
        {
            value = EditorGUI.RectField(position, label, value);
            return self;
        }
        public static IRectGUI RectField(this IRectGUI self, Rect position, string label, ref Rect value)
        {
            value = EditorGUI.RectField(position, label, value);
            return self;
        }
        public static IRectGUI RectField(this IRectGUI self, Rect position, ref Rect value)
        {
            value = EditorGUI.RectField(position, value);
            return self;
        }
        public static IRectGUI ObjectField(this IRectGUI self, Rect position, string label, ref UnityEngine.Object obj, Type objType, bool allowSceneObjects)
        {
            obj = EditorGUI.ObjectField(position, label, obj, objType, allowSceneObjects);
            return self;
        }
        public static IRectGUI ObjectField(this IRectGUI self, Rect position, GUIContent label, ref UnityEngine.Object obj, Type objType, bool allowSceneObjects)
        {
            obj = EditorGUI.ObjectField(position, label, obj, objType, allowSceneObjects);
            return self;
        }
        public static IRectGUI IntField(this IRectGUI self, Rect position, GUIContent label, ref int value)
        {
            value = EditorGUI.IntField(position, label, value);
            return self;
        }
        public static IRectGUI IntField(this IRectGUI self, Rect position, ref int value)
        {
            value = EditorGUI.IntField(position, value);
            return self;
        }
        public static IRectGUI IntField(this IRectGUI self, Rect position, ref int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.IntField(position, value, style);
            return self;
        }
        public static IRectGUI IntField(this IRectGUI self, Rect position, GUIContent label, ref int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.IntField(position, label, value, style);
            return self;
        }
        public static IRectGUI IntField(this IRectGUI self, Rect position, string label, ref int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.IntField(position, label, value, style);
            return self;
        }
        public static IRectGUI IntField(this IRectGUI self, Rect position, string label, ref int value)
        {
            value = EditorGUI.IntField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, GUIContent label, ref int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedIntField(position, label, value, style);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, ref int value)
        {
            value = EditorGUI.DelayedIntField(position, value);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, ref int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedIntField(position, value, style);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, string label, ref int value)
        {
            value = EditorGUI.DelayedIntField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, GUIContent label, ref int value)
        {
            value = EditorGUI.DelayedIntField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedIntField(this IRectGUI self, Rect position, string label, ref int value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedIntField(position, label, value, style);
            return self;
        }
        public static IRectGUI RectIntField(this IRectGUI self, Rect position, ref RectInt value)
        {
            value = EditorGUI.RectIntField(position, value);
            return self;
        }
        public static IRectGUI RectIntField(this IRectGUI self, Rect position, string label, ref RectInt value)
        {
            value = EditorGUI.RectIntField(position, label, value);
            return self;
        }
        public static IRectGUI RectIntField(this IRectGUI self, Rect position, GUIContent label, ref RectInt value)
        {
            value = EditorGUI.RectIntField(position, label, value);
            return self;
        }
        public static IRectGUI LongField(this IRectGUI self, Rect position, GUIContent label, ref long value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.LongField(position, label, value, style);
            return self;
        }
        public static IRectGUI LongField(this IRectGUI self, Rect position, GUIContent label, ref long value)
        {
            value = EditorGUI.LongField(position, label, value);
            return self;
        }
        public static IRectGUI LongField(this IRectGUI self, Rect position, ref long value)
        {
            value = EditorGUI.LongField(position, value);
            return self;
        }
        public static IRectGUI LongField(this IRectGUI self, Rect position, string label, ref long value)
        {
            value = EditorGUI.LongField(position, label, value);
            return self;
        }
        public static IRectGUI LongField(this IRectGUI self, Rect position, ref long value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.LongField(position, value, style);
            return self;
        }
        public static IRectGUI LongField(this IRectGUI self, Rect position, string label, ref long value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.LongField(position, label, value, style);
            return self;
        }
        public static IRectGUI FloatField(this IRectGUI self, Rect position, string label, ref float value)
        {
            value = EditorGUI.FloatField(position, label, value);
            return self;
        }
        public static IRectGUI FloatField(this IRectGUI self, Rect position, GUIContent label, ref float value)
        {
            value = EditorGUI.FloatField(position, label, value);
            return self;
        }
        public static IRectGUI FloatField(this IRectGUI self, Rect position, ref float value)
        {
            value = EditorGUI.FloatField(position, value);
            return self;
        }
        public static IRectGUI FloatField(this IRectGUI self, Rect position, GUIContent label, ref float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.FloatField(position, label, value, style);
            return self;
        }
        public static IRectGUI FloatField(this IRectGUI self, Rect position, string label, ref float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.FloatField(position, label, value, style);
            return self;
        }
        public static IRectGUI FloatField(this IRectGUI self, Rect position, ref float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.FloatField(position, value, style);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, ref float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedFloatField(position, value, style);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, GUIContent label, ref float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedFloatField(position, label, value, style);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, string label, ref float value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedFloatField(position, label, value, style);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, GUIContent label, ref float value)
        {
            value = EditorGUI.DelayedFloatField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, string label, ref float value)
        {
            value = EditorGUI.DelayedFloatField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedFloatField(this IRectGUI self, Rect position, ref float value)
        {
            value = EditorGUI.DelayedFloatField(position, value);
            return self;
        }
        public static IRectGUI DoubleField(this IRectGUI self, Rect position, ref double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DoubleField(position, value, style);
            return self;
        }
        public static IRectGUI DoubleField(this IRectGUI self, Rect position, GUIContent label, ref double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DoubleField(position, label, value, style);
            return self;
        }
        public static IRectGUI DoubleField(this IRectGUI self, Rect position, string label, ref double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DoubleField(position, label, value, style);
            return self;
        }
        public static IRectGUI DoubleField(this IRectGUI self, Rect position, string label, ref double value)
        {
            value = EditorGUI.DoubleField(position, label, value);
            return self;
        }
        public static IRectGUI DoubleField(this IRectGUI self, Rect position, ref double value)
        {
            value = EditorGUI.DoubleField(position, value);
            return self;
        }
        public static IRectGUI DoubleField(this IRectGUI self, Rect position, GUIContent label, ref double value)
        {
            value = EditorGUI.DoubleField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedDoubleField(this IRectGUI self, Rect position, GUIContent label, ref double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedDoubleField(position, label, value, style);
            return self;
        }
        public static IRectGUI DelayedDoubleField(this IRectGUI self, Rect position, ref double value)
        {
            value = EditorGUI.DelayedDoubleField(position, value);
            return self;
        }
        public static IRectGUI DelayedDoubleField(this IRectGUI self, Rect position, string label, ref double value)
        {
            value = EditorGUI.DelayedDoubleField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedDoubleField(this IRectGUI self, Rect position, GUIContent label, ref double value)
        {
            value = EditorGUI.DelayedDoubleField(position, label, value);
            return self;
        }
        public static IRectGUI DelayedDoubleField(this IRectGUI self, Rect position, ref double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedDoubleField(position, value, style);
            return self;
        }
        public static IRectGUI DelayedDoubleField(this IRectGUI self, Rect position, string label, ref double value, [DefaultValue("EditorStyles.numberField")] GUIStyle style)
        {
            value = EditorGUI.DelayedDoubleField(position, label, value, style);
            return self;
        }
        public static IRectGUI Vector2Field(this IRectGUI self, Rect position, GUIContent label, ref Vector2 value)
        {
            value = EditorGUI.Vector2Field(position, label, value);
            return self;
        }
        public static IRectGUI Vector2Field(this IRectGUI self, Rect position, string label, ref Vector2 value)
        {
            value = EditorGUI.Vector2Field(position, label, value);
            return self;
        }
        public static IRectGUI Vector3Field(this IRectGUI self, Rect position, GUIContent label, ref Vector3 value)
        {
            value = EditorGUI.Vector3Field(position, label, value);
            return self;
        }
        public static IRectGUI Vector3Field(this IRectGUI self, Rect position, string label, ref Vector3 value)
        {
            value = EditorGUI.Vector3Field(position, label, value);
            return self;
        }
        public static IRectGUI Vector4Field(this IRectGUI self, Rect position, string label, ref Vector4 value)
        {
            value = EditorGUI.Vector4Field(position, label, value);
            return self;
        }
        public static IRectGUI Vector4Field(this IRectGUI self, Rect position, GUIContent label, ref Vector4 value)
        {
            value = EditorGUI.Vector4Field(position, label, value);
            return self;
        }
        public static IRectGUI Vector2IntField(this IRectGUI self, Rect position, GUIContent label, ref Vector2Int value)
        {
            value = EditorGUI.Vector2IntField(position, label, value);
            return self;
        }
        public static IRectGUI Vector2IntField(this IRectGUI self, Rect position, string label, ref Vector2Int value)
        {
            value = EditorGUI.Vector2IntField(position, label, value);
            return self;
        }
        public static IRectGUI Vector3IntField(this IRectGUI self, Rect position, GUIContent label, ref Vector3Int value)
        {
            value = EditorGUI.Vector3IntField(position, label, value);
            return self;
        }
        public static IRectGUI Vector3IntField(this IRectGUI self, Rect position, string label, ref Vector3Int value)
        {
            value = EditorGUI.Vector3IntField(position, label, value);
            return self;
        }
#if !UNITY_2017_3_OR_NEWER
        public static IRectGUIDrawer EnumMaskField(this IRectGUIDrawer self, Rect position, ref Enum enumValue, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            enumValue = EditorGUI.EnumMaskField(position, enumValue, style);
            return self;
        }
        public static IRectGUIDrawer EnumMaskField(this IRectGUIDrawer self, Rect position, ref Enum enumValue)
        {
            enumValue = EditorGUI.EnumMaskField(position, enumValue);
            return self;
        }
        public static IRectGUIDrawer EnumMaskField(this IRectGUIDrawer self, Rect position, string label, ref Enum enumValue, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            enumValue = EditorGUI.EnumMaskField(position, label, enumValue, style);
            return self;
        }
        public static IRectGUIDrawer EnumMaskField(this IRectGUIDrawer self, Rect position, string label, ref Enum enumValue)
        {
            enumValue = EditorGUI.EnumMaskField(position, label, enumValue);
            return self;
        }
        public static IRectGUIDrawer EnumMaskPopup(this IRectGUIDrawer self, Rect position, string label, ref Enum selected, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selected = EditorGUI.EnumMaskPopup(position, label, selected, style);
            return self;
        }
        public static IRectGUIDrawer EnumMaskPopup(this IRectGUIDrawer self, Rect position, string label, ref Enum selected)
        {
            selected = EditorGUI.EnumMaskPopup(position, label, selected);
            return self;
        }
        public static IRectGUIDrawer EnumMaskField(this IRectGUIDrawer self, Rect position, GUIContent label, ref Enum enumValue, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            enumValue = EditorGUI.EnumMaskField(position, label, enumValue, style);
            return self;
        }
        public static IRectGUIDrawer EnumMaskField(this IRectGUIDrawer self, Rect position, GUIContent label, ref Enum enumValue)
        {
            enumValue = EditorGUI.EnumMaskField(position, label, enumValue);
            return self;
        }
        public static IRectGUIDrawer EnumMaskPopup(this IRectGUIDrawer self, Rect position, GUIContent label, ref Enum selected)
        {
            selected = EditorGUI.EnumMaskPopup(position, label, selected);
            return self;
        }
        public static IRectGUIDrawer EnumMaskPopup(this IRectGUIDrawer self, Rect position, GUIContent label, ref Enum selected, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selected = EditorGUI.EnumMaskPopup(position, label, selected, style);
            return self;
        }
#endif
        public static IRectGUI CurveField(this IRectGUI self, Rect position, GUIContent label, ref AnimationCurve value, Color color, Rect ranges)
        {
            value = EditorGUI.CurveField(position, label, value, color, ranges);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, GUIContent label, ref AnimationCurve value)
        {
            value = EditorGUI.CurveField(position, label, value);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, string label, ref AnimationCurve value, Color color, Rect ranges)
        {
            value = EditorGUI.CurveField(position, label, value, color, ranges);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, string label, ref AnimationCurve value)
        {
            value = EditorGUI.CurveField(position, label, value);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, ref AnimationCurve value, Color color, Rect ranges)
        {
            value = EditorGUI.CurveField(position, value, color, ranges);
            return self;
        }
        public static IRectGUI CurveField(this IRectGUI self, Rect position, ref AnimationCurve value)
        {
            value = EditorGUI.CurveField(position, value);
            return self;
        }
        public static IRectGUI LayerField(this IRectGUI self, Rect position, GUIContent label, ref int layer, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            layer = EditorGUI.LayerField(position, label, layer, style);
            return self;
        }
        public static IRectGUI LayerField(this IRectGUI self, Rect position, GUIContent label, ref int layer)
        {
            layer = EditorGUI.LayerField(position, label, layer);
            return self;
        }
        public static IRectGUI LayerField(this IRectGUI self, Rect position, string label, ref int layer)
        {
            layer = EditorGUI.LayerField(position, label, layer);
            return self;
        }
        public static IRectGUI LayerField(this IRectGUI self, Rect position, string label, ref int layer, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            layer = EditorGUI.LayerField(position, label, layer, style);
            return self;
        }
        public static IRectGUI LayerField(this IRectGUI self, Rect position, ref int layer, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            layer = EditorGUI.LayerField(position, layer, style);
            return self;
        }
        public static IRectGUI LayerField(this IRectGUI self, Rect position, ref int layer)
        {
            layer = EditorGUI.LayerField(position, layer);
            return self;
        }
        public static IRectGUI MaskField(this IRectGUI self, Rect position, GUIContent label, ref int mask, string[] displayedOptions)
        {
            mask = EditorGUI.MaskField(position, label, mask, displayedOptions);
            return self;
        }
        public static IRectGUI MaskField(this IRectGUI self, Rect position, GUIContent label, ref int mask, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            mask = EditorGUI.MaskField(position, label, mask, displayedOptions, style);
            return self;
        }
        public static IRectGUI MaskField(this IRectGUI self, Rect position, string label, ref int mask, string[] displayedOptions)
        {
            mask = EditorGUI.MaskField(position, label, mask, displayedOptions);
            return self;
        }
        public static IRectGUI MaskField(this IRectGUI self, Rect position, string label, ref int mask, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            mask = EditorGUI.MaskField(position, label, mask, displayedOptions, style);
            return self;
        }
        public static IRectGUI MaskField(this IRectGUI self, Rect position, ref int mask, string[] displayedOptions)
        {
            mask = EditorGUI.MaskField(position, mask, displayedOptions);
            return self;
        }
        public static IRectGUI MaskField(this IRectGUI self, Rect position, ref int mask, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            mask = EditorGUI.MaskField(position, mask, displayedOptions, style);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, GUIContent label, ref int selectedIndex, GUIContent[] displayedOptions)
        {
            selectedIndex = EditorGUI.Popup(position, label, selectedIndex, displayedOptions);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, GUIContent label, ref int selectedIndex, GUIContent[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedIndex = EditorGUI.Popup(position, label, selectedIndex, displayedOptions, style);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, ref int selectedIndex, string[] displayedOptions)
        {
            selectedIndex = EditorGUI.Popup(position, selectedIndex, displayedOptions);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, ref int selectedIndex, GUIContent[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedIndex = EditorGUI.Popup(position, selectedIndex, displayedOptions, style);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, ref int selectedIndex, GUIContent[] displayedOptions)
        {
            selectedIndex = EditorGUI.Popup(position, selectedIndex, displayedOptions);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, ref int selectedIndex, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {

            selectedIndex = EditorGUI.Popup(position, selectedIndex, displayedOptions, style);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, string label, ref int selectedIndex, string[] displayedOptions)
        {
            selectedIndex = EditorGUI.Popup(position, selectedIndex, displayedOptions);
            return self;
        }
        public static IRectGUI Popup(this IRectGUI self, Rect position, string label, ref int selectedIndex, string[] displayedOptions, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedIndex = EditorGUI.Popup(position, label, selectedIndex, displayedOptions, style);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, string label, ref int selectedValue, string[] displayedOptions, int[] optionValues)
        {
            selectedValue = EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, string label, ref int selectedValue, string[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedValue = EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues, style);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, GUIContent label, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues)
        {
            selectedValue = EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, GUIContent label, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedValue = EditorGUI.IntPopup(position, label, selectedValue, displayedOptions, optionValues, style);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedValue = EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues, style);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, ref int selectedValue, GUIContent[] displayedOptions, int[] optionValues)
        {
            selectedValue = EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, ref int selectedValue, string[] displayedOptions, int[] optionValues)
        {
            selectedValue = EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues);
            return self;
        }
        public static IRectGUI IntPopup(this IRectGUI self, Rect position, ref int selectedValue, string[] displayedOptions, int[] optionValues, [DefaultValue("EditorStyles.popup")] GUIStyle style)
        {
            selectedValue = EditorGUI.IntPopup(position, selectedValue, displayedOptions, optionValues, style);
            return self;
        }
#if NET_4_6

        public static IRectGUI EnumPopup<T>(this IRectGUI self, Rect position, ref T selected) where T : Enum
        {
            selected = (T)EditorGUI.EnumPopup(position, selected);
            return self;
        }
        public static IRectGUI EnumPopup<T>(this IRectGUI self, Rect position, ref T selected, [DefaultValue("EditorStyles.popup")] GUIStyle style) where T : Enum
        {
            selected = (T)EditorGUI.EnumPopup(position, selected, style);
            return self;
        }
        public static IRectGUI EnumPopup<T>(this IRectGUI self, Rect position, string label, ref T selected)where T:Enum
        {
            selected = (T)EditorGUI.EnumPopup(position, label, selected);
            return self;
        }
        public static IRectGUI EnumPopup<T>(this IRectGUI self, Rect position, string label, ref T selected, [DefaultValue("EditorStyles.popup")] GUIStyle style) where T : Enum
        {
            selected = (T)EditorGUI.EnumPopup(position, label, selected, style);
            return self;
        }
        public static IRectGUI EnumPopup<T>(this IRectGUI self, Rect position, GUIContent label, ref T selected) where T : Enum
        {
            selected = (T)EditorGUI.EnumPopup(position, label, selected);
            return self;
        }
        public static IRectGUI EnumPopup<T>(this IRectGUI self, Rect position, GUIContent label, ref T selected, [DefaultValue("EditorStyles.popup")] GUIStyle style) where T : Enum
        {
            selected = (T)EditorGUI.EnumPopup(position, label, selected, style);
            return self;
        }
#endif
        public static IRectGUI Slider(this IRectGUI self, Rect position, GUIContent label, ref float value, float leftValue, float rightValue)
        {
            value = EditorGUI.Slider(position, label, value, leftValue, rightValue);
            return self;
        }
        public static IRectGUI Slider(this IRectGUI self, Rect position, string label, ref float value, float leftValue, float rightValue)
        {
            value = EditorGUI.Slider(position, label, value, leftValue, rightValue);
            return self;
        }
        public static IRectGUI Slider(this IRectGUI self, Rect position, ref float value, float leftValue, float rightValue)
        {
            value = EditorGUI.Slider(position, value, leftValue, rightValue);
            return self;
        }
        public static IRectGUI IntSlider(this IRectGUI self, Rect position, string label, ref int value, int leftValue, int rightValue)
        {
            value = EditorGUI.IntSlider(position, label, value, leftValue, rightValue);
            return self;
        }
        public static IRectGUI IntSlider(this IRectGUI self, Rect position, GUIContent label, ref int value, int leftValue, int rightValue)
        {
            value = EditorGUI.IntSlider(position, label, value, leftValue, rightValue);
            return self;
        }
        public static IRectGUI IntSlider(this IRectGUI self, Rect position, ref int value, int leftValue, int rightValue)
        {
            value = EditorGUI.IntSlider(position, value, leftValue, rightValue);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, GUIContent content, bool toggleOnLabelClick)
        {
            foldout = EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, string content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick, style);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, GUIContent content)
        {
            foldout = EditorGUI.Foldout(position, foldout, content);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, GUIContent content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUI.Foldout(position, foldout, content, style);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, GUIContent content, bool toggleOnLabelClick, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick, style);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, string content, bool toggleOnLabelClick)
        {
            foldout = EditorGUI.Foldout(position, foldout, content, toggleOnLabelClick);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, string content, [DefaultValue("EditorStyles.foldout")] GUIStyle style)
        {
            foldout = EditorGUI.Foldout(position, foldout, content, style);
            return self;
        }
        public static IRectGUI Foldout(this IRectGUI self, Rect position, ref bool foldout, string content)
        {
            foldout = EditorGUI.Foldout(position, foldout, content);
            return self;
        }
        public static IRectGUI InspectorTitlebar(this IRectGUI self, Rect position, ref bool foldout, UnityEngine.Object targetObj, bool expandable)
        {
            foldout = EditorGUI.InspectorTitlebar(position, foldout, targetObj, expandable);
            return self;
        }
        public static IRectGUI InspectorTitlebar(this IRectGUI self, Rect position, ref bool foldout, UnityEngine.Object[] targetObjs, bool expandable)
        {
            foldout = EditorGUI.InspectorTitlebar(position, foldout, targetObjs, expandable);
            return self;
        }
        public static IRectGUI Toggle(this IRectGUI self, Rect position, ref bool value)
        {
            value = EditorGUI.Toggle(position, value);
            return self;
        }
        public static IRectGUI Toggle(this IRectGUI self, Rect position, ref bool value, GUIStyle style)
        {
            value = EditorGUI.Toggle(position, value, style);
            return self;
        }
        public static IRectGUI Toggle(this IRectGUI self, Rect position, string label, ref bool value, GUIStyle style)
        {
            value = EditorGUI.Toggle(position, label, value, style);
            return self;
        }
        public static IRectGUI Toggle(this IRectGUI self, Rect position, string label, ref bool value)
        {
            value = EditorGUI.Toggle(position, label, value);
            return self;
        }
        public static IRectGUI Toggle(this IRectGUI self, Rect position, GUIContent label, ref bool value, GUIStyle style)
        {
            value = EditorGUI.Toggle(position, label, value, style);
            return self;
        }
        public static IRectGUI Toggle(this IRectGUI self, Rect position, GUIContent label, ref bool value)
        {
            value = EditorGUI.Toggle(position, label, value);
            return self;
        }
        public static IRectGUI ToggleLeft(this IRectGUI self, Rect position, string label, ref bool value)
        {
            value = EditorGUI.ToggleLeft(position, label, value);
            return self;
        }
        public static IRectGUI ToggleLeft(this IRectGUI self, Rect position, string label, ref bool value, [DefaultValue("EditorStyles.label")] GUIStyle labelStyle)
        {
            value = EditorGUI.ToggleLeft(position, label, value, labelStyle);
            return self;
        }
        public static IRectGUI ToggleLeft(this IRectGUI self, Rect position, GUIContent label, ref bool value)
        {
            value = EditorGUI.ToggleLeft(position, label, value);
            return self;
        }
        public static IRectGUI ToggleLeft(this IRectGUI self, Rect position, GUIContent label, ref bool value, [DefaultValue("EditorStyles.label")] GUIStyle labelStyle)
        {
            value = EditorGUI.ToggleLeft(position, label, value, labelStyle);
            return self;
        }
                                    
        public static IRectGUI BeginProperty(this IRectGUI self, Rect totalPosition, ref GUIContent label, SerializedProperty property)
        {
            label = EditorGUI.BeginProperty(totalPosition, label, property);
            return self;
        }
        public static IRectGUI EndProperty(this IRectGUI self)
        {
            EditorGUI.EndProperty();
            return self;
        }
        public static IRectGUI BeginChangeCheck(this IRectGUI self)
        {
            EditorGUI.BeginChangeCheck();
            return self;
        }
        public static IRectGUI EndChangeCheck(this IRectGUI self)
        {
            EditorGUI.EndChangeCheck();
            return self;
        }
        public static IRectGUI BeginDisabledGroup(this IRectGUI self, bool disabled)
        {
            EditorGUI.BeginDisabledGroup(disabled);
            return self;
        }
        public static IRectGUI EndDisabledGroup(this IRectGUI self)
        {
            EditorGUI.EndDisabledGroup();
            return self;
        }
    }
}
