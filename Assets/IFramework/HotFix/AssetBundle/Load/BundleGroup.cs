﻿/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.3.11f1
 *Date:           2019-04-06
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;

namespace IFramework.Hotfix.AB
{
    [Serializable]
    public class BundleGroup
    {
        public string assetBundleName;
        public string[] assetNames;
        public BundleGroup() { }
        public BundleGroup(string assetBundleName, string[] assetNames)
        {
            this.assetNames = assetNames;
            this.assetBundleName = assetBundleName;
        }
    }

}
