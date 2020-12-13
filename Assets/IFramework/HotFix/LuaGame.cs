/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.115
 *UnityVersion:   2018.4.24f1
 *Date:           2020-11-29
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework.Hotfix.AB;
using IFramework.Language;
using IFramework.Hotfix.Lua;
using IFramework.Modules;
using IFramework.Modules.Coroutine;
using IFramework.Modules.Message;
using IFramework.UI;
using System;

namespace IFramework.Hotfix
{
    public class LuaGame : Game
    {
        public class UnityModules
        {
            public IUIModule UI { get { return Launcher.modules.FindModule<UIModule>(""); } }
            public ILanguageModule Lan { get { return Launcher.modules.FindModule<LanguageModule>(""); } }
        }

        public UnityModules unityModules = new UnityModules();
        public override void CreateModules()
        {
           
        }

        public override void Startup()
        {
            UpdateAssets();
            Assets.Init();
            XLuaEnv.AddLoader(new AssetBundleLoader());
            new XluaMain();
        }

        private void UpdateAssets()
        {
           
        }
    }
}
