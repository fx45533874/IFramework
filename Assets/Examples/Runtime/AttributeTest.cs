using System.Collections;
using System.Collections.Generic;
using IFramework;
using IFramework.GUITool.Inspector;
using UnityEngine;
using static IFramework.GUITool.Inspector.HelpBoxAttribute;

namespace IFramework_Demo
{
    public class AttributeTest : MonoBehaviour
    {
        public bool hh;
        [ToggleShowAttribute("hh")]
        public string xx;

        [SearchableString("SSR")]
        public string ssr;
        private string[] SSR = { "11" };


        [SerializeField, SetProperty("TX")]
        private string tx;

        public string TX
        {
            get
            {
                return tx;
            }
            private set
            {
                tx = value.ToUpper();
            }
        }
        public string txt;
        [AssetPreview]
        public GameObject go;
        [MethodButton(method = "SayTest")]
        public int test = 11;
        private void SayTest()
        {
            Debug.Log(SSR);
            Debug.Log(test);
        }
        [ProgressBar(text = "", minValue = -10, maxValue = 10, showSlider = false)]
        public int sl;
        [ProgressBar(text = " ", minValue = -10, maxValue = 10)]
        public float s2;
        [Reset]
        public int cc;

        [BeginReadOnlyGroup]
        [HelpBox("help")]
        public string a;
        [HelpBox("help", MessageType.Warning)]
        public int b;
        [HelpBox("help", MessageType.Info)]
        public Material c;
        [HelpBox("help", messageType = MessageType.Error)]
        public List<int> d = new List<int>();
        //public c e; // Works!
        [ReadOnly] public string a2;
        [ReadOnly] public int e2; // DOES NOT USE CustomPropertyDrawer!
        [FoldoutAttribute("BB", true)]

        public int b2;
        [HelpBox("help", messageType = MessageType.Error)]
        public Material c2;
        [EndReadOnlyGroup]
        public List<int> d2 = new List<int>();
        [SearchableEnum]
        public KeyCode key;
        [SearchableEnum]
        public int key2;
        [SearchableEnum]
        public List<int> key3;
        [FoldoutAttribute("aa", true)]
        public int aa;
        public List<int> bbb;
        public List<int> cccb;
        public List<int> ccb;
        [FoldoutAttribute("bb", true)]

        public List<int> ccxcb;


    }

}
