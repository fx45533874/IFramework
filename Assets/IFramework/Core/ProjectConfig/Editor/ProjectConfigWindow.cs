﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.1f1
 *Date:           2019-03-23
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using System.IO;
using UnityEngine;
using IFramework.GUITool;
using UnityEditor.Callbacks;

namespace IFramework
{
    [EditorWindowCache]
    partial class ProjectConfigWindow
    {
        [CustomEditor(typeof(ProjectConfigInfo))]
        class ProjectConfigView : Editor
        {
            private static bool isEnable;
            private void OnEnable()
            {
                isEnable = true;
            }
            private void OnDisable()
            {
                isEnable = false;
            }

            //固定写法，双击打开自定义面板
            [OnOpenAsset(1)]
            public static bool OpenAsset(int instanceID, int line)
            {
                bool open = isEnable && EditorWindow.focusedWindow.titleContent.text == "Project";
                if (open)
                    ProjectConfigWindow.ShowWindow();
                return open;
            }


            public override void OnInspectorGUI()
            {
                GUI.enabled = false;
                base.OnInspectorGUI();
                GUI.enabled = true;
                GUILayout.Space(10);
                if (GUILayout.Button("Open"))
                {
                    ProjectConfigWindow.ShowWindow();
                }
            }
        }
        private static void ShowWindow()
        {
            GetWindow<ProjectConfigWindow>(false, "ProjectConfig", true);
        }
    }
    partial class ProjectConfigWindow : EditorWindow, ILayoutGUI
    {
        private ProjectConfigInfo Info;
        private void OnEnable()
        {
            string ProjectConfigInfoPath = EditorEnv.corePath.CombinePath("ProjectConfig/Resources/"+ ProjectConfig.configName + ".asset").ToRegularPath();

            if (File.Exists(ProjectConfigInfoPath))
                Info = EditorTools.ScriptableObjectTool.Load<ProjectConfigInfo>(ProjectConfigInfoPath);
            else
            {
                Info = EditorTools.ScriptableObjectTool.Create<ProjectConfigInfo>(ProjectConfigInfoPath);

                Info.enable_L = Log.enable_L;
                Info.enable_W = Log.enable_W;
                Info.enable_E = Log.enable_E;
                Info.enable = Log.enable;
            }
        }
        private void OnDisable()
        {
            EditorTools.ScriptableObjectTool.Update(Info);
        }

        private void OnGUI()
        {


            this.Space()
                    .ETextField(new GUIContent("UserName","Project Author's Name"), ref Info.UserName)
                    .ETextField(new GUIContent("Version","Version of Project"), ref Info.Version)
                    .LabelField(new GUIContent("NameSpace","Script's Namespace"))
                    .TextArea(ref Info.NameSpace)
                    .Label("Description of Scripts")
                    .TextArea(ref Info.Description, GUILayout.Height(100))
                    .Space(10);
            //.FlexibleSpace();
          
            this.Label("LogSetting",GUIStyles.Get("IN Title"))
                .Toggle("Enable", ref Info.enable)
                .Pan(() =>
                {
                    GUI.enabled = Info.enable;
                    this.Toggle("Log Enable", ref Info.enable_L)
                        .Toggle("Warning Enable", ref Info.enable_W)
                        .Toggle("Error Enable", ref Info.enable_E);

                    GUI.enabled = true;
                }).FlexibleSpace();


            this.BeginHorizontal()
                        .FlexibleSpace()
                        .Button(() => { EditorTools.ScriptableObjectTool.Update(Info); }, "Save")
                    .EndHorizontal();
        }


    }
}
