/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-08-28
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using UnityEngine;

namespace IFramework.GUITool
{
    public static partial class ILayoutGUIEx
    {
        public static ILayoutGUI FlexibleSpace(this ILayoutGUI self)
        {
            GUILayout.FlexibleSpace(); return self;
        }
        public static ILayoutGUI Space(this ILayoutGUI self, float pixels)
        {
            GUILayout.Space(pixels); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect)
        {
            GUILayout.BeginArea(rect);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, string text)
        {
            GUILayout.BeginArea(rect, text);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, Texture image)
        {
            GUILayout.BeginArea(rect, image);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, GUIContent content)
        {
            GUILayout.BeginArea(rect, content);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, GUIStyle style)
        {
            GUILayout.BeginArea(rect, style);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, string text, GUIStyle style)
        {
            GUILayout.BeginArea(rect, text, style);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, Texture image, GUIStyle style)
        {
            GUILayout.BeginArea(rect, image, style);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawArea(this ILayoutGUI self, Action draw, Rect rect, GUIContent content, GUIStyle style)
        {
            GUILayout.BeginArea(rect, content, style);
            if (draw != null) draw();
            GUILayout.EndArea(); return self;
        }
        public static ILayoutGUI DrawHorizontal(this ILayoutGUI self, Action draw, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(text, style, options);
            if (draw != null) draw();
            GUILayout.EndHorizontal(); return self;
        }
        public static ILayoutGUI DrawHorizontal(this ILayoutGUI self, Action draw, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(image, style, options);
            if (draw != null) draw();
            GUILayout.EndHorizontal(); return self;
        }
        public static ILayoutGUI DrawHorizontal(this ILayoutGUI self, Action draw, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(content, style, options);
            if (draw != null) draw();
            GUILayout.EndHorizontal(); return self;
        }
        public static ILayoutGUI DrawHorizontal(this ILayoutGUI self, Action draw, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(options);
            if (draw != null) draw();
            GUILayout.EndHorizontal(); return self;
        }
        public static ILayoutGUI DrawHorizontal(this ILayoutGUI self, Action draw, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(style, options);
            if (draw != null) draw();
            GUILayout.EndHorizontal(); return self;
        }
        public static ILayoutGUI DrawVertical(this ILayoutGUI self, Action draw, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(text, style, options);
            if (draw != null) draw();
            GUILayout.EndVertical(); return self;
        }
        public static ILayoutGUI DrawVertical(this ILayoutGUI self, Action draw, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(image, style, options);
            if (draw != null) draw();
            GUILayout.EndVertical(); return self;
        }
        public static ILayoutGUI DrawVertical(this ILayoutGUI self, Action draw, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(content, style, options);
            if (draw != null) draw();
            GUILayout.EndVertical(); return self;
        }
        public static ILayoutGUI DrawVertical(this ILayoutGUI self, Action draw, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(options);
            if (draw != null) draw();
            GUILayout.EndVertical(); return self;
        }
        public static ILayoutGUI DrawVertical(this ILayoutGUI self, Action draw, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(style, options);
            if (draw != null) draw();
            GUILayout.EndVertical(); return self;
        }
        public static ILayoutGUI Box(this ILayoutGUI self, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Box(image, style, options); return self;
        }
        public static ILayoutGUI Box(this ILayoutGUI self, GUIContent content, params GUILayoutOption[] options)
        {
            GUILayout.Box(content, options); return self;
        }
        public static ILayoutGUI Box(this ILayoutGUI self, string text, params GUILayoutOption[] options)
        {
            GUILayout.Box(text, options); return self;
        }
        public static ILayoutGUI Box(this ILayoutGUI self, Texture image, params GUILayoutOption[] options)
        {
            GUILayout.Box(image, options); return self;
        }
        public static ILayoutGUI Box(this ILayoutGUI self, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Box(text, style, options); return self;
        }
        public static ILayoutGUI Box(this ILayoutGUI self, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Box(content, style, options); return self;
        }
        public static ILayoutGUI Button(this ILayoutGUI self, Action listener, Texture image, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.Button(image, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI Button(this ILayoutGUI self, Action listener, string text, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.Button(text, options);
            if (listener != null && bo)
            {
                listener();
            }
         
            return self;
        }
        public static ILayoutGUI Button(this ILayoutGUI self, Action listener, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.Button(text, style, options);
            if (listener != null && bo)
            {
                listener();
            }
           
            return self;
        }
        public static ILayoutGUI Button(this ILayoutGUI self, Action listener, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.Button(image, style, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI Button(this ILayoutGUI self, Action listener, GUIContent content, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.Button(content, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI Button(this ILayoutGUI self, Action listener, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.Button(content, style, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI RepeatButton(this ILayoutGUI self, Action listener, string text, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.RepeatButton(text, options);
            if (listener != null && bo)
            {
                listener();
            }
          
            return self;
        }
        public static ILayoutGUI RepeatButton(this ILayoutGUI self, Action listener, GUIContent content, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.RepeatButton(content, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI RepeatButton(this ILayoutGUI self, Action listener, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.RepeatButton(image, style, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI RepeatButton(this ILayoutGUI self, Action listener, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.RepeatButton(text, style, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI RepeatButton(this ILayoutGUI self, Action listener, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.RepeatButton(content, style, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI RepeatButton(this ILayoutGUI self, Action listener, Texture image, params GUILayoutOption[] options)
        {
            bool bo = GUILayout.RepeatButton(image, options);
            if (listener != null && bo)
            {
                listener();
            }
            return self;
        }
        public static ILayoutGUI Label(this ILayoutGUI self, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Label(content, style, options); return self;
        }
        public static ILayoutGUI Label(this ILayoutGUI self, GUIContent content, params GUILayoutOption[] options)
        {
            GUILayout.Label(content, options); return self;
        }
        public static ILayoutGUI Label(this ILayoutGUI self, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Label(image, style, options); return self;
        }
        public static ILayoutGUI Label(this ILayoutGUI self, string text, params GUILayoutOption[] options)
        {
            GUILayout.Label(text, options); return self;
        }
        public static ILayoutGUI Label(this ILayoutGUI self, Texture image, params GUILayoutOption[] options)
        {
            GUILayout.Label(image, options); return self;
        }
        public static ILayoutGUI Label(this ILayoutGUI self, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.Label(text, style, options); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, horizontalScrollbar, verticalScrollbar, options);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, GUIStyle style, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, style, options);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, GUIStyle style)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, style);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, alwaysShowHorizontal, alwaysShowVertical, options);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI DrawScrollView(this ILayoutGUI self, Action draw, ref Vector2 scrollPos, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, options);
            if (draw != null) draw();
            GUILayout.EndScrollView(); return self;
        }
        public static ILayoutGUI HorizontalScrollbar(this ILayoutGUI self, ref float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, options); return self;
        }
        public static ILayoutGUI HorizontalScrollbar(this ILayoutGUI self, ref float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
        {
            value = GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, options); return self;
        }
        public static ILayoutGUI HorizontalSlider(this ILayoutGUI self, ref float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
        {
            value = GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, options); return self;
        }
        public static ILayoutGUI HorizontalSlider(this ILayoutGUI self, ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = GUILayout.HorizontalSlider(value, leftValue, rightValue, options); return self;
        }
        public static ILayoutGUI VerticalScrollbar(this ILayoutGUI self, ref float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = GUILayout.VerticalScrollbar(value, size, leftValue, rightValue, options); return self;
        }
        public static ILayoutGUI VerticalScrollbar(this ILayoutGUI self, ref float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
        {
            value = GUILayout.VerticalScrollbar(value, size, leftValue, rightValue, style, options); return self;
        }
        public static ILayoutGUI VerticalSlider(this ILayoutGUI self, ref float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
        {
            value = GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, options); return self;
        }
        public static ILayoutGUI VerticalSlider(this ILayoutGUI self, ref float value, float leftValue, float rightValue, params GUILayoutOption[] options)
        {
            value = GUILayout.VerticalSlider(value, leftValue, rightValue, options); return self;
        }
        public static ILayoutGUI SelectionGrid(this ILayoutGUI self, ref int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = GUILayout.SelectionGrid(selected, contents, xCount, style, options); return self;
        }
        public static ILayoutGUI SelectionGrid(this ILayoutGUI self, ref int selected, string[] texts, int xCount, params GUILayoutOption[] options)
        {
            selected = GUILayout.SelectionGrid(selected, texts, xCount, options); return self;
        }
        public static ILayoutGUI SelectionGrid(this ILayoutGUI self, ref int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = GUILayout.SelectionGrid(selected, images, xCount, style, options); return self;
        }
        public static ILayoutGUI SelectionGrid(this ILayoutGUI self, ref int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = GUILayout.SelectionGrid(selected, texts, xCount, style, options); return self;
        }
        public static ILayoutGUI SelectionGrid(this ILayoutGUI self, ref int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
        {
            selected = GUILayout.SelectionGrid(selected, content, xCount, options); return self;
        }
        public static ILayoutGUI SelectionGrid(this ILayoutGUI self, ref int selected, Texture[] images, int xCount, params GUILayoutOption[] options)
        {
            selected = GUILayout.SelectionGrid(selected, images, xCount, options); return self;
        }
        public static ILayoutGUI TextField(this ILayoutGUI self, ref string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
        {
            text = GUILayout.TextField(text, maxLength, style, options); return self;
        }
        public static ILayoutGUI TextField(this ILayoutGUI self, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = GUILayout.TextField(text, style, options); return self;
        }
        public static ILayoutGUI TextField(this ILayoutGUI self, ref string text, int maxLength, params GUILayoutOption[] options)
        {
            text = GUILayout.TextField(text, maxLength, options); return self;
        }
        public static ILayoutGUI TextField(this ILayoutGUI self, ref string text, params GUILayoutOption[] options)
        {
            text = GUILayout.TextField(text, options); return self;
        }
        public static ILayoutGUI TextArea(this ILayoutGUI self, ref string text, int maxLength, params GUILayoutOption[] options)
        {
            text = GUILayout.TextArea(text, maxLength, options); return self;
        }
        public static ILayoutGUI TextArea(this ILayoutGUI self, ref string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
        {
            text = GUILayout.TextArea(text, maxLength, style, options); return self;
        }
        public static ILayoutGUI TextArea(this ILayoutGUI self, ref string text, params GUILayoutOption[] options)
        {
            text = GUILayout.TextArea(text, options); return self;
        }
        public static ILayoutGUI TextArea(this ILayoutGUI self, ref string text, GUIStyle style, params GUILayoutOption[] options)
        {
            text = GUILayout.TextArea(text, style, options); return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, ref string password, char maskChar, params GUILayoutOption[] options)
        {
            password = GUILayout.PasswordField(password, maskChar, options); return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, ref string password, char maskChar, int maxLength, params GUILayoutOption[] options)
        {
            password = GUILayout.PasswordField(password, maskChar, maxLength, options); return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, ref string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
        {
            password = GUILayout.PasswordField(password, maskChar, style, options); return self;
        }
        public static ILayoutGUI PasswordField(this ILayoutGUI self, ref string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
        {
            password = GUILayout.PasswordField(password, maskChar, maxLength, style, options); return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, Texture image, params GUILayoutOption[] options)
        {
            value = GUILayout.Toggle(value, image, options); return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, string text, params GUILayoutOption[] options)
        {
            value = GUILayout.Toggle(value, text, options); return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, GUIContent content, params GUILayoutOption[] options)
        {
            value = GUILayout.Toggle(value, content, options); return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            value = GUILayout.Toggle(value, text, style, options); return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            value = GUILayout.Toggle(value, content, style, options); return self;
        }
        public static ILayoutGUI Toggle(this ILayoutGUI self, ref bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            value = GUILayout.Toggle(value, image, style, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, Texture[] images, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, images, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, GUIContent[] contents, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, contents, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, texts, style, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, string[] texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, texts, style, buttonSize, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, Texture[] images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, images, style, buttonSize, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, contents, style, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, contents, style, buttonSize, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, string[] texts, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, texts, options); return self;
        }
        public static ILayoutGUI Toolbar(this ILayoutGUI self, ref int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options)
        {
            selected = GUILayout.Toolbar(selected, images, style, options); return self;
        }
        public static ILayoutGUI Window(this ILayoutGUI self, int id, ref Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            screenRect = GUILayout.Window(id, screenRect, func, image, style, options); return self;
        }
        public static ILayoutGUI Window(this ILayoutGUI self, int id, ref Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            screenRect = GUILayout.Window(id, screenRect, func, content, style, options); return self;
        }
        public static ILayoutGUI Window(this ILayoutGUI self, int id, ref Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
        {
            screenRect = GUILayout.Window(id, screenRect, func, content, options); return self;
        }
        public static ILayoutGUI Window(this ILayoutGUI self, int id, ref Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
        {
            screenRect = GUILayout.Window(id, screenRect, func, image, options); return self;
        }
        public static ILayoutGUI Window(this ILayoutGUI self, int id, ref Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
        {
            screenRect = GUILayout.Window(id, screenRect, func, text, options); return self;
        }
        public static ILayoutGUI Window(this ILayoutGUI self, int id, ref Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            screenRect = GUILayout.Window(id, screenRect, func, text, style, options); return self;
        }


        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect)
        {
            GUILayout.BeginArea(rect);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, string text)
        {
            GUILayout.BeginArea(rect, text);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, Texture image)
        {
            GUILayout.BeginArea(rect, image);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, GUIContent content)
        {
            GUILayout.BeginArea(rect, content);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, GUIStyle style)
        {
            GUILayout.BeginArea(rect, style);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, string text, GUIStyle style)
        {
            GUILayout.BeginArea(rect, text, style);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, Texture image, GUIStyle style)
        {
            GUILayout.BeginArea(rect, image, style);
            return self;
        }
        public static ILayoutGUI BeginArea(this ILayoutGUI self, Rect rect, GUIContent content, GUIStyle style)
        {
            GUILayout.BeginArea(rect, content, style);
            return self;
        }

        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, horizontalScrollbar, verticalScrollbar, options);
            return self;
        }
        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options);
            return self;
        }
        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, GUIStyle style, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, style, options);
            return self;
        }
        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, GUIStyle style)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, style);
            return self;
        }
        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
            return self;
        }
        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, alwaysShowHorizontal, alwaysShowVertical, options);
            return self;
        }
        public static ILayoutGUI BeginScrollView(this ILayoutGUI self, ref Vector2 scrollPos, params GUILayoutOption[] options)
        {
            scrollPos = GUILayout.BeginScrollView(scrollPos, options);
            return self;
        }
        public static ILayoutGUI BeginHorizontal(this ILayoutGUI self, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(text, style, options);
            return self;
        }
        public static ILayoutGUI BeginHorizontal(this ILayoutGUI self, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(image, style, options);
            return self;
        }
        public static ILayoutGUI BeginHorizontal(this ILayoutGUI self, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(content, style, options);
            return self;
        }
        public static ILayoutGUI BeginHorizontal(this ILayoutGUI self, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(options);
            return self;
        }
        public static ILayoutGUI BeginHorizontal(this ILayoutGUI self, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(style, options);
            return self;
        }
        public static ILayoutGUI BeginVertical(this ILayoutGUI self, string text, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(text, style, options);
            return self;
        }
        public static ILayoutGUI BeginVertical(this ILayoutGUI self, Texture image, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(image, style, options);
            return self;
        }
        public static ILayoutGUI BeginVertical(this ILayoutGUI self, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(content, style, options);
            return self;
        }
        public static ILayoutGUI BeginVertical(this ILayoutGUI self, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(options);
            return self;
        }
        public static ILayoutGUI BeginVertical(this ILayoutGUI self, GUIStyle style, params GUILayoutOption[] options)
        {
            GUILayout.BeginVertical(style, options);
            return self;
        }
        public static ILayoutGUI LayoutEndScrollView(this ILayoutGUI self)
        {
            GUILayout.EndScrollView();
            return self;
        }
        public static ILayoutGUI EndHorizontal(this ILayoutGUI self)
        {
            GUILayout.EndHorizontal();
            return self;
        }
        public static ILayoutGUI EndVertical(this ILayoutGUI self)
        {
            GUILayout.EndVertical();
            return self;
        }
        public static ILayoutGUI EndArea(this ILayoutGUI self)
        {
            GUILayout.EndArea();
            return self;
        }
    }

}
