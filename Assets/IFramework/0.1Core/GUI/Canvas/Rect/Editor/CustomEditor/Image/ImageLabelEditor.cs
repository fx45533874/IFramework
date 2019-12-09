﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-12-07
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using UnityEngine;

namespace IFramework.GUITool.RectDesign
{
    [CustomGUIElement(typeof(ImageLabel))]
    public class ImageLabelEditor : ImageElementEditor
    {
        private ImageLabel image { get { return element as ImageLabel; } }

        public override void OnSceneGUI(Action children)
        {
            if (!image.active) return;
            BeginGUI();
            GUI.Label(image.position, image.image, image.imageStyle);
            if (children != null) children();

            EndGUI();
        }
    }
}
