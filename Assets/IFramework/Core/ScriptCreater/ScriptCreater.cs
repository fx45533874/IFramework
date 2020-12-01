﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-07-30
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEngine;

namespace IFramework
{
    [DisallowMultipleComponent]
    public class ScriptCreater : MonoBehaviour
    {
        public string ScriptName="newSp.cs";
        public string CreatePath="Assets";
        public ScriptMark[] scriptMarks;
        public string description="";
        private void OnEnable()
        {
            Destroy(this);
        }
    }
}
