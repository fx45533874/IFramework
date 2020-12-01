/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-05-12
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework.GUITool;
using UnityEditor;
using UnityEngine;

namespace IFramework.GUITool.Inspector
{
    [CustomPropertyDrawer(typeof(ProgressBarAttribute))]
    internal class ProgressBarAttributeDrawer : PropertyDrawer
    {
        private const string BarTextStyle =  "ProgressBarText";
        private GUIStyle barText;
        private GUIStyle BarText
        {
            get {
                if (barText==null)
                {
                    barText = GUIStyles.Get(BarTextStyle);
                    barText.alignment = TextAnchor.MiddleCenter;
                }
                return barText;
            }
        }
        private ProgressBarAttribute Bar { get { return attribute as ProgressBarAttribute; } }
        private float BarHeight
        {
            get
            {
                var style = GUIStyles.Get("ProgressBarBar");
                var content = new GUIContent(Bar.text);
                return Mathf.Max(style.CalcHeight(content, Screen.width - 53), Bar.minHeight);
            }
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (Bar.showSlider)
                return base.GetPropertyHeight(property, label) + BarHeight;
            return BarHeight;

        }
        private Rect barRect;
        private Rect SliderRect;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (Bar.showSlider)
            {
                barRect = new Rect(position.x,
                                          position.y + position.height - BarHeight,
                                          position.width,
                                          BarHeight).Zoom(  AnchorType.MiddleCenter,new Vector2(-10, -5));
                SliderRect = new Rect(position.x,
                                                position.y,
                                                position.width,
                                                position.height - BarHeight);
            }
            else
            {
                barRect = position.Zoom(AnchorType.MiddleCenter, new Vector2(-10, -5));
            }
           
            Eve(barRect, property);
            GUI.color = Bar.color;
            if (property.propertyType ==  SerializedPropertyType.Float)
            {
                if (Bar.showSlider)
                    EditorGUI.Slider(SliderRect,property,Bar.minValue,Bar.maxValue );

                EditorGUI.ProgressBar(barRect,(property.floatValue -Bar.minValue)/ (Bar.maxValue-Bar.minValue),"");
                if (Event.current.type == EventType.Repaint)
                    if (string.IsNullOrEmpty(Bar.text.Trim()))
                        BarText.Draw(barRect,
                            string.Format("{0}  [{1}/{2}]  :\t{3}  F", property.name.UpperFirst(), Bar.minValue, Bar.maxValue, property.floatValue),
                            false, false, false, false);
                    else BarText.Draw(barRect, Bar.text, false, false, false, false);

            }
            else if (property.propertyType == SerializedPropertyType.Integer)
            {
                if (Bar.showSlider)
                    EditorGUI.IntSlider(SliderRect,property,(int)Bar.minValue,(int)Bar.maxValue);

                EditorGUI.ProgressBar(barRect,(float)(property.intValue - (int)Bar.minValue) / ((int)Bar.maxValue - (int)Bar.minValue), "");
                if (Event.current.type == EventType.Repaint)
                    if (string.IsNullOrEmpty(Bar.text.Trim()))
                        BarText.Draw(barRect, 
                            string.Format("{0}  [{1}/{2}]  :\t{3}  D", property.name.UpperFirst(),Bar.minValue,Bar.maxValue,property.intValue), 
                            false, false, false, false);
                    else BarText.Draw(barRect, Bar.text, false, false, false, false);
            }
            
           
            GUI.color = Color.white;
        }

        private void Eve(Rect pos, SerializedProperty property)
        {
            Event e = Event.current;
            if (!pos.Zoom( AnchorType.MiddleCenter,new Vector2(4, 0)).Contains(e.mousePosition) || e.type!= EventType.MouseDrag) return;
            float width = e.mousePosition.x - pos.x;
            if (property.propertyType == SerializedPropertyType.Float)
            {
                property.floatValue = width / pos.width * (Bar.maxValue - Bar.minValue) + Bar.minValue;
                if (e.mousePosition.x > pos.xMax)
                {
                    property.floatValue = Bar.maxValue;
                }
                if (e.mousePosition.x < pos.xMin)
                {
                    property.floatValue = Bar.minValue;
                }
            }
            else
            {
                float space = pos.width / (Bar.maxValue - Bar.minValue);
                float real = (property.intValue - Bar.minValue) * space ;
                if (real < width - space)
                {
                    property.intValue++;
                }
                else if (real > width + space)
                    property.intValue--;
                if (e.mousePosition.x>pos.xMax)
                {
                    property.intValue = (int)Bar.maxValue;
                }
                if (e.mousePosition.x < pos.xMin)
                {
                    property.intValue = (int)Bar.minValue;
                }
            }
            e.Use();
        } 
       

    }
}
