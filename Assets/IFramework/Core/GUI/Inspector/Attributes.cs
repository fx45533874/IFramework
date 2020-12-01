/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.97
 *UnityVersion:   2018.4.24f1
 *Date:           2020-12-04
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEngine;

namespace IFramework.GUITool.Inspector
{
    public class ReadOnlyAttribute : PropertyAttribute { }
    public class BeginReadOnlyGroupAttribute : PropertyAttribute { }
    public class EndReadOnlyGroupAttribute : PropertyAttribute { }
    public class SearchableEnumAttribute : PropertyAttribute { }
    public class ResetAttribute : PropertyAttribute { }



    public class AssetPreviewAttribute : PropertyAttribute
    {
        public int width = 64;
        public int height = 64;
    }
    public class FoldoutAttribute : PropertyAttribute
    {
        public string name;
        public bool foldEverything;
        public FoldoutAttribute(string name, bool foldEverything = false)
        {
            this.foldEverything = foldEverything;
            this.name = name;
        }
    }
    public class HelpBoxAttribute : PropertyAttribute
    {
        public enum MessageType
        {
            None = 0,
            Info = 1,
            Warning = 2,
            Error = 3
        }
        public MessageType messageType;
        public string message;
        public HelpBoxAttribute(string message, MessageType messageType = MessageType.None)
        {
            this.message = message;
            this.messageType = messageType;
        }
    }
    public class ToggleShowAttribute : PropertyAttribute
    {
        public string checkProperty { get; private set; }
        public ToggleShowAttribute(string checkProperty)
        {
            this.checkProperty = checkProperty;
        }
    }
    public class MethodButtonAttribute : PropertyAttribute
    {
        public string name;
        public string method;
    }
    public class ProgressBarAttribute : PropertyAttribute
    {
        public string text;
        public float minValue;
        public float maxValue;
        public Color color = Color.white;
        public float minHeight = 40f;
        public bool showSlider = false;
    }
    public class SetPropertyAttribute : PropertyAttribute
    {
        public string name { get; private set; }
        public bool dirty { get; set; }

        public SetPropertyAttribute(string name)
        {
            this.name = name;
        }
    }
    public class SearchableStringAttribute : PropertyAttribute
    {
        public SearchableStringAttribute(string searchArray) { this.searchArray = searchArray; }
        public string searchArray;
    }
}
