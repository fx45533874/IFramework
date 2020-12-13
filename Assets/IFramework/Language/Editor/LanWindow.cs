/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2017.2.3p3
 *Date:           2019-09-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using IFramework.Serialization;
using IFramework.GUITool;
using IFramework.GUITool.ToorbarMenu;
using IFramework.Serialization.DataTable;
namespace IFramework.Language
{
    [EditorWindowCache("IFramework.Language")]
    partial class LanWindow : EditorWindow
    {
        [CustomPropertyDrawer(typeof(LanguageKeyAttribute))]
        class LanguageKeyDrawer : PropertyDrawer
        {
            private LanGroup _LanGroup { get { return AssetDatabase.LoadAssetAtPath<LanGroup>(EditorEnv.frameworkPath.CombinePath(LanGroup.assetPath)); } }
            private int _hashID;
            public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
            {
                if (property.type != "string")
                {
                    EditorGUI.PropertyField(position, property, label, true);
                    return;
                }
                if (_hashID == 0) _hashID = "LanguageKeyDrawer".GetHashCode();
                int ctrlId = GUIUtility.GetControlID(_hashID, FocusType.Keyboard, position);
                {
                    label = EditorGUI.BeginProperty(position, label, property);
                    position = EditorGUI.PrefixLabel(position, ctrlId, label);
                    if (DropdownButton(ctrlId, position, new GUIContent(property.stringValue)))
                    {
                        int index = -1;
                        for (int i = 0; i < _LanGroup.keys.Count; i++)
                        {
                            if (_LanGroup.keys[i] == property.stringValue)
                            {
                                index = i;
                                break;
                            }
                        }
                        SearchablePopup.Show(position, _LanGroup.keys.ToArray(), index, (i, str) =>
                        {
                            property.stringValue = str;
                            property.serializedObject.ApplyModifiedProperties();
                        });
                    }
                }
                EditorGUI.EndProperty();
            }

            private static bool DropdownButton(int id, Rect position, GUIContent content)
            {
                Event e = Event.current;
                switch (e.type)
                {
                    case EventType.MouseDown:
                        if (position.Contains(e.mousePosition) && e.button == 0)
                        {
                            Event.current.Use();
                            return true;
                        }
                        break;
                    case EventType.KeyDown:
                        if (GUIUtility.keyboardControl == id && e.character == '\n')
                        {
                            Event.current.Use();
                            return true;
                        }
                        break;
                    case EventType.Repaint:
                        EditorStyles.toolbarTextField.Draw(position, content, id, false);
                        break;
                }
                return false;
            }

        }
        private class Styles
        {
            public static GUIStyle EntryBackodd = "CN EntryBackodd";
            public static GUIStyle EntryBackEven = "CN EntryBackEven";
            public static GUIStyle Title = "IN BigTitle";
            public static GUIStyle TitleTxt = "IN BigTitle Inner";
            public static GUIStyle BoldLabel = EditorStyles.boldLabel;
            public static GUIStyle toolbarButton = EditorStyles.toolbarButton;
            public static GUIStyle toolbar = EditorStyles.toolbar;
            public static GUIStyle Fold = GUIStyles.Get("ToolbarDropDown");
            public static GUIStyle FoldOut = EditorStyles.foldout;
            public static GUIStyle CloseBtn = "WinBtnClose";
            public static GUIStyle minus = "OL Minus";
            public static GUIStyle BG = "box";
            public static GUIStyle box = "box";
            public static GUIStyle in_title = new GUIStyle("IN Title") { fixedHeight = 20 + 5 };
            public static GUIStyle settingsHeader = "SettingsHeader";
            public static GUIStyle header = "DD HeaderStyle";
            public static GUIStyle toolbarSeachTextFieldPopup = "ToolbarSeachTextFieldPopup";
            public static GUIStyle searchTextField = new GUIStyle("ToolbarTextField")
            {
                margin = new RectOffset(0, 0, 2, 0)
            };
            public static GUIStyle searchCancelButton = "ToolbarSeachCancelButton";
            public static GUIStyle searchCancelButtonEmpty = "ToolbarSeachCancelButtonEmpty";
            public static GUIStyle foldout = "Foldout";
            public static GUIStyle ToolbarDropDown = "ToolbarDropDown";
            public static GUIStyle selectionRect = "SelectionRect";

            static Styles()
            {
                Fold.fixedHeight = BoldLabel.fixedHeight;
            }
        }
        private class Contents
        {

            public static GUIContent CreateViewTitle = new GUIContent("Create", EditorGUIUtility.IconContent("tree_icon_leaf").image);
            public static GUIContent GroupTitle = new GUIContent("Group", EditorGUIUtility.IconContent("d_tree_icon_frond").image);
            public static GUIContent CopyBtn = new GUIContent("C", "Copy");
            public static GUIContent OK = EditorGUIUtility.IconContent("vcs_add");
            public static GUIContent Warnning = EditorGUIUtility.IconContent("console.warnicon.sml");

        }
        private const string CreateViewNmae = "CreateView";
        private const string Group = "Group";
        private static CreateView createView = new CreateView();
        private GroupView group = new GroupView();

        [SerializeField]
        private string tmpLayout;
        private const float ToolBarHeight = 17;
        private Rect localPosition { get { return new Rect(Vector2.zero, position.size); } }
        private SubWinTree sunwin;
        private ToolBarTree ToolBarTree;


        private abstract class LanwindowItem : ILayoutGUI, IRectGUI
        {
            public static LanWindow window;
            public Rect position;

            protected float TitleHeight { get { return Styles.Title.CalcHeight(titleContent, position.width); } }
            protected float smallBtnSize = 20;
            protected float describeWidth = 30;
            protected virtual GUIContent titleContent { get; }
            public void OnGUI(Rect position)
            {
                this.position = position;
                position.DrawOutLine(2, Color.black);
                this.DrawClip(() => {
                    Rect[] rs = position.HorizontalSplit(TitleHeight);
                    this.Box(rs[0]);
                    this.Box(rs[0], titleContent, Styles.Title);
                    DrawContent(rs[1]);
                }, position);

            }
            protected abstract void DrawContent(Rect rect);
        }
    }
    partial class LanWindow : EditorWindow
    {
        private LanGroup _group;
        private List<LanPair> _pairs { get { return _group.pairs; } }
        private List<string> _keys { get { return _group.keys; } }

        private string stoPath;
        private void OnEnable()
        {
            LanwindowItem.window = this;
            stoPath = EditorEnv.frameworkPath.CombinePath(LanGroup.assetPath);
            LoadLanGroup();
            this.titleContent = new GUIContent("Lan", EditorGUIUtility.IconContent("d_WelcomeScreen.AssetStoreLogo").image);
            SubwinInit();
        }
        private void LoadLanGroup()
        {
            if (File.Exists(stoPath))
                _group = EditorTools.ScriptableObjectTool.Load<LanGroup>(stoPath);
            else
                _group = EditorTools.ScriptableObjectTool.Create<LanGroup>(stoPath);
        }
        private void UpdateLanGroup()
        {
            EditorTools.ScriptableObjectTool.Update(_group);
        }
        private void OnDisable()
        {
            tmpLayout = sunwin.Serialize();
            UpdateLanGroup();
        }

        private void Views(Rect rect)
        {
            GenericMenu menu = new GenericMenu();

            for (int i = 0; i < sunwin.allLeafCount; i++)
            {
                SubWinTree.TreeLeaf leaf = sunwin.allLeafs[i];
                menu.AddItem(leaf.titleContent, !sunwin.closedLeafs.Contains(leaf), () => {
                    if (sunwin.closedLeafs.Contains(leaf))
                        sunwin.DockLeaf(leaf, SubWinTree.DockType.Left);
                    else
                        sunwin.CloseLeaf(leaf);
                });
            }
            menu.DropDown(rect);
            Event.current.Use();
        }
        private void SubwinInit()
        {
            sunwin = new SubWinTree();
            sunwin.repaintEve += Repaint;
            sunwin.drawCursorEve += (rect, sp) =>
            {
                if (sp == SplitType.Vertical)
                    EditorGUIUtility.AddCursorRect(rect, MouseCursor.ResizeHorizontal);
                else
                    EditorGUIUtility.AddCursorRect(rect, MouseCursor.ResizeVertical);
            };
            if (string.IsNullOrEmpty(tmpLayout))
            {
                for (int i = 1; i <= 2; i++)
                {
                    string userdata = i == 1 ? "Group" : "CreateView";
                    SubWinTree.TreeLeaf L = sunwin.CreateLeaf(new GUIContent(userdata));
                    L.userData = userdata;
                    sunwin.DockLeaf(L, SubWinTree.DockType.Left);
                }
            }
            else
            {
                sunwin.DeSerialize(tmpLayout);
            }
            sunwin[Group].titleContent = new GUIContent(Group);
            sunwin[Group].minSize = new Vector2(250, 250);
            sunwin[CreateViewNmae].minSize = new Vector2(300, 300);
            sunwin[Group].paintDelegate += group.OnGUI;
            sunwin[CreateViewNmae].paintDelegate += createView.OnGUI;


            ToolBarTree = new ToolBarTree();
            ToolBarTree.DropDownButton(new GUIContent("Views"), Views, 60)
                            .FlexibleSpace()
                            .Toggle(new GUIContent("Title"), (bo) => { sunwin.isShowTitle = bo; }, sunwin.isShowTitle, 60)
                            .Toggle(new GUIContent("Lock"), (bo) => { sunwin.isLocked = bo; }, sunwin.isLocked, 60);

        }
        private void OnGUI()
        {
            var rs = localPosition.Zoom(AnchorType.MiddleCenter, -2).HorizontalSplit(ToolBarHeight, 4);
            ToolBarTree.OnGUI(rs[0]);
            sunwin.OnGUI(rs[1]);
            this.minSize = sunwin.minSize + new Vector2(0, ToolBarHeight);
        }

        private void DeletePairsByKey(string key)
        {
            _group.DeletePairsByKey(key);
            UpdateLanGroup();
        }
        private void DeleteLanPair(LanPair pair)
        {
            _group.DeletePair(pair);
        }
        private void AddLanPair(LanPair pair)
        {
            if (string.IsNullOrEmpty(pair.value.Trim()))
            {
                ShowNotification(new GUIContent("Value Can't be Null"));
                return;
            }
            LanPair tmpPair = new LanPair()
            {
                lan = pair.lan,
                key = pair.key,
                value = pair.value
            };
            LanPair lp = _pairs.Find((p) => { return p.lan == tmpPair.lan && p.key == tmpPair.key; });
            if (lp == null)
            {
                _pairs.Add(tmpPair);
                UpdateLanGroup();
            }
            else
            {
                if (lp.value == tmpPair.value)
                    ShowNotification(new GUIContent("Don't Add Same"));
                else
                {
                    if (EditorUtility.DisplayDialog("Warn",
                        string.Format("Replace Old Value ?\n Old Value  {0}\n New Vlaue  {1}", lp.value, tmpPair.value), "Yes", "No"))
                    {
                        lp.value = tmpPair.value;
                    }
                }
            }
        }

        private void AddLanGroupKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                ShowNotification(new GUIContent("Err: key is Empty " + key));
                return;
            }
            if (!_keys.Contains(key))
            {
                _keys.Add(key);
                UpdateLanGroup();
            }
            else
            {
                ShowNotification(new GUIContent("Err: key Has Exist " + key));
            }
        }
        private void DeleteLanKey(string key)
        {
            if (_keys.Contains(key))
            {
                _keys.Remove(key);
                DeletePairsByKey(key);
            }
        }
        private void CleanData()
        {
            _pairs.Clear();
            _keys.Clear();
            UpdateLanGroup();
        }
        private void WriteXml(string path)
        {
            path.WriteText(Xml.ToXml(_pairs), Encoding.UTF8);
        }
        private void ReadXml(string path)
        {
            List<LanPair> ps = Xml.FromXml<List<LanPair>>(path.ReadText(Encoding.UTF8))
                .Distinct()
                .ToList().FindAll((p) => { return !string.IsNullOrEmpty(p.key) && !string.IsNullOrEmpty(p.value); });
            AddLanPairs(ps);
        }
        private void WriteJson(string path)
        {
            path.WriteText(JsonUtility.ToJson(_pairs), Encoding.UTF8);
        }
        private void ReadJson(string path)
        {
            List<LanPair> ps = JsonUtility.FromJson<List<LanPair>>(path.ReadText(Encoding.UTF8))
               .Distinct()
               .ToList().FindAll((p) => { return !string.IsNullOrEmpty(p.key) && !string.IsNullOrEmpty(p.value); });
            AddLanPairs(ps);
        }
        private bool IsKeyInUse(string key)
        {
            for (int i = 0; i < _pairs.Count; i++)
            {
                if (_pairs[i].key == key)
                {
                    return true;
                }
            }
            return false;
        }
        private void ReadCsv(string path)
        {
            var dw = DataTableTool.CreateReader(new StreamReader(path, System.Text.Encoding.UTF8), new DataRow(), new DataExplainer());
            var pairs = dw.Get<LanPair>().Distinct()
                 .ToList().FindAll((p) => { return !string.IsNullOrEmpty(p.key) && !string.IsNullOrEmpty(p.value); });
            dw.Dispose();
            AddLanPairs(pairs);
        }
        private void ReadScriptableObject(string path)
        {
            var g = AssetDatabase.LoadAssetAtPath<LanGroup>(path.ToAssetsPath());
            if (g == null) return;
            AddLanPairs(g.pairs);
        }
        private void WriteScriptableObject(string path)
        {
            if (!File.Exists(path))
                EditorTools.ScriptableObjectTool.Create<LanGroup>(path.ToAssetsPath());
            var g = EditorTools.ScriptableObjectTool.Load<LanGroup>(path.ToAssetsPath());
            if (g == null) return;
            g.pairs.AddRange(_pairs);
            g.pairs.Distinct();
            EditorTools.ScriptableObjectTool.Update(g);
        }

        private void WriteCsv(string path)
        {
            var w = DataTableTool.CreateWriter(new StreamWriter(path, false),
                           new DataRow(),
                           new DataExplainer());
            w.Write(_pairs);
            w.Dispose();
        }


        private void AddLanPairs(List<LanPair> pairs)
        {
            if (pairs == null || pairs.Count == 0) return;
            for (int i = 0; i < pairs.Count; i++)
            {
                var filePair = pairs[i];
                if (!_keys.Contains(filePair.key)) _keys.Add(filePair.key);
                LanPair oldPair = _pairs.Find((pair) => { return pair.key == filePair.key && pair.lan == filePair.lan; });
                if (oldPair == null) _pairs.Add(filePair);
                else
                {
                    if (oldPair.value != filePair.value)
                    {
                        if (EditorUtility.DisplayDialog("Warning",
                                            "The LanPair Is Same Do You Want Replace \n"
                                            .Append(string.Format("Lan {0}\t\t Key {0}\t \n", oldPair.lan, oldPair.key))
                                            .Append(string.Format("Old  Val\t\t {0}\n", oldPair.value))
                                            .Append(string.Format("New  Val\t\t {0}\n", filePair.value))
                                            , "Yes", "No"))
                        {
                            oldPair.value = filePair.value;
                        }
                    }
                }
            }
            UpdateLanGroup();
        }
        [Serializable]
        private class CreateView : LanwindowItem
        {
            public CreateView()
            {
                searchField = new SearchField("", null, 0);

                searchField.onValueChange += (str) => {
                    keySearchStr = str;
                };
            }
            protected override GUIContent titleContent { get { return Contents.CreateViewTitle; } }
            [SerializeField] private bool toolFoldon;
            private void Tool()
            {
                Rect rect;
                this.EBeginHorizontal(out rect, Styles.Fold)
                    .Foldout(ref toolFoldon, "Tool", true);
                this.EEndHorizontal()
                    .Pan(() => {
                        if (!toolFoldon) return;
                        this.BeginHorizontal()
                                      .Button(() => {
                                          window.LoadLanGroup();
                                      }, "Fresh")
                                      .Button(() => {
                                          window.UpdateLanGroup();
                                      }, "Save")
                                      .Button(() => {
                                          window.CleanData();
                                      }, "Clear")
                                 .EndHorizontal()
                                 .BeginHorizontal()
                                     .Button(() => {
                                         string path = EditorUtility.OpenFilePanel("xml (End with  xml)", Application.dataPath, "xml");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".xml")) return;
                                         window.ReadXml(path);
                                     }, "Read Xml")
                                     .Button(() => {
                                         string path = EditorUtility.SaveFilePanel("xml (End with  xml)", Application.dataPath,"LanGroup", "xml");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".xml")) return;
                                         window.WriteXml(path);
                                     }, "Write Xml")
                                 .EndHorizontal()
                                 .BeginHorizontal()
                                     .Button(() => {
                                         string path = EditorUtility.OpenFilePanel("json (End With json)", Application.dataPath, "json");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".json")) return;
                                         window.ReadJson(path);
                                     }, "Read Json")
                                     .Button(() => {
                                         string path = EditorUtility.SaveFilePanel("json (End With json)", Application.dataPath, "LanGroup", "json");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".json")) return;
                                         window.WriteJson(path);
                                     }, "Write Json")
                                 .EndHorizontal()
                                 .BeginHorizontal()
                                     .Button(() => {
                                         string path = EditorUtility.OpenFilePanel("csv (End With csv)", Application.dataPath, "csv");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".csv")) return;
                                         window.ReadCsv(path);
                                     }, "Read Csv")
                                     .Button(() => {
                                         string path = EditorUtility.SaveFilePanel("csv (End With csv)", Application.dataPath, "LanGroup", "csv");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".csv")) return;
                                         window.WriteCsv(path);
                                     }, "Write Csv")
                                 .EndHorizontal()
                                 .BeginHorizontal()
                                     .Button(() => {
                                         string path = EditorUtility.OpenFilePanel("ScriptableObject (End With asset)", Application.dataPath, "asset");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".asset")) return;
                                         window.ReadScriptableObject(path);
                                     }, "Read ScriptableObject")
                                     .Button(() => {
                                         string path = EditorUtility.SaveFilePanel("ScriptableObject (End With asset)", Application.dataPath, "LanGroup", "asset");
                                         if (string.IsNullOrEmpty(path) || !path.EndsWith(".asset")) return;
                                         window.WriteScriptableObject(path);
                                     }, "Write ScriptableObject")
                                 .EndHorizontal();
                    });
            }
            [SerializeField] private bool creatingKeyFoldon;
            [SerializeField] private string tmpKey;
            private void CreateLanKey()
            {
                Rect rect;
                this.EBeginHorizontal(out rect, Styles.Fold)
                    .Foldout(ref creatingKeyFoldon, "Create Key", true)
                    .EEndHorizontal()
                    .Pan(() => {
                        if (!creatingKeyFoldon) return;
                        this.EBeginHorizontal(out rect, Styles.BG)
                                   .ETextField(ref tmpKey)
                                   .Button(() =>
                                   {
                                       window.AddLanGroupKey(tmpKey);
                                       tmpKey = string.Empty;
                                   }, Contents.OK, GUILayout.Width(describeWidth))
                                  .EEndHorizontal();
                    });
            }

            [SerializeField] private bool createLanPairFlodon;
            [SerializeField] private LanPair tmpLanPair = new LanPair();
            [SerializeField] private int hashID;
            private void AddLanPairFunc()
            {

                if (window._keys.Count == 0) return;
                Rect rect;

                this.EBeginHorizontal(out rect, Styles.Fold)
                    .Foldout(ref createLanPairFlodon, "Create LanPair", true)
                    .EEndHorizontal()
                    .Pan(() =>
                    {
                        if (!createLanPairFlodon) return;
                        if (tmpLanPair == null) tmpLanPair = new LanPair() { key = window._keys[0] };
                        if (hashID == 0) hashID = "CreateView".GetHashCode();
                        this.DrawVertical(() =>
                        {
                            this.BeginHorizontal()
                                    .Label("Lan", GUILayout.Width(describeWidth))
                                    .Pan(() => { tmpLanPair.lan = (SystemLanguage)EditorGUILayout.EnumPopup(tmpLanPair.lan); })
                                .EndHorizontal()
                                .BeginHorizontal()
                                    .Label("Key", GUILayout.Width(describeWidth))
                                    .Label(tmpLanPair.key)
                                    .Label(EditorGUIUtility.IconContent("editicon.sml"), GUILayout.Width(smallBtnSize))
                                .EndHorizontal()
                                .Pan(() =>
                                {
                                    Rect pos = GUILayoutUtility.GetLastRect();
                                    int ctrlId = GUIUtility.GetControlID(hashID, FocusType.Keyboard, pos);
                                    {
                                        if (DropdownButton(ctrlId, pos, new GUIContent(string.Format("Key: {0}", tmpLanPair.key))))
                                        {
                                            int index = -1;
                                            for (int i = 0; i < window._keys.Count; i++)
                                            {
                                                if (window._keys[i] == tmpLanPair.key)
                                                {
                                                    index = i; break;
                                                }
                                            }
                                            SearchablePopup.Show(pos, window._keys.ToArray(), index, (i, str) =>
                                            {
                                                tmpLanPair.key = str;
                                                window.Repaint();
                                            });
                                        }
                                    }
                                })
                               .BeginHorizontal()
                                    .Label("Val", GUILayout.Width(describeWidth))
                                    .ETextField(ref tmpLanPair.value)
                                    .EndHorizontal()
                                .BeginHorizontal()
                                    .FlexibleSpace()
                                    .Button(() => {
                                        //createLanPairFlodon = false;
                                        window.AddLanPair(tmpLanPair);
                                        //tmpLanPair = null;
                                    }, Contents.OK)
                                .EndHorizontal();
                        }, Styles.BG);
                    });
            }
            private bool DropdownButton(int id, Rect position, GUIContent content)
            {
                Event e = Event.current;
                switch (e.type)
                {
                    case EventType.MouseDown:
                        if (position.Contains(e.mousePosition) && e.button == 0)
                        {
                            Event.current.Use();
                            return true;
                        }
                        break;
                    case EventType.KeyDown:
                        if (GUIUtility.keyboardControl == id && e.character == '\n')
                        {
                            Event.current.Use();
                            return true;
                        }
                        break;
                    case EventType.Repaint:
                        //Styles.BoldLabel.Draw(position, content, id, false);
                        break;
                }
                return false;
            }

            [SerializeField] private bool keyFoldon;
            [SerializeField] private Vector2 scroll;
            [SerializeField] private string keySearchStr = string.Empty;
            private SearchField searchField;
            private void LanGroupKeysView()
            {
                this.DrawHorizontal(() => {
                    this.Foldout(ref keyFoldon, string.Format("Keys  Count: {0}", window._keys.Count), true);
                    this.Label("");
                    searchField.OnGUI(GUILayoutUtility.GetLastRect());
                }, Styles.Fold);
                if (keyFoldon)
                {
                    this.DrawScrollView(() => {
                        window._keys.ForEach((index, key) => {
                            if (key.ToLower().Contains(keySearchStr.ToLower()))
                            {
                                this.BeginHorizontal(Styles.BG)
                                    .SelectableLabel(key, GUILayout.Height(20))
                                    .Label(window.IsKeyInUse(key) ? GUIContent.none : Contents.Warnning, GUILayout.Width(smallBtnSize))
                                    .Button(() => {
                                        if (EditorUtility.DisplayDialog("Make sure", "You Will Delete All Pairs with this key", "ok", "no"))
                                            window.DeleteLanKey(key);
                                    }, string.Empty, Styles.CloseBtn, GUILayout.Width(smallBtnSize), GUILayout.Height(smallBtnSize))
                                    .EndHorizontal();
                            }
                        });
                    }, ref scroll);
                }
            }

            protected override void DrawContent(Rect rect)
            {
                this
                    .Pan(() =>
                    {
                        this.BeginArea(rect.Zoom(AnchorType.MiddleCenter, -10))
                            .Pan(Tool)
                            .Space(5)
                            .Pan(AddLanPairFunc)
                            .Space(5)
                            .Pan(CreateLanKey)
                            .Space(5)
                            .Pan(LanGroupKeysView)
                            .EndArea();
                    });
            }

        }



        [Serializable]
        private class GroupView : LanwindowItem
        {
            protected override GUIContent titleContent { get { return Contents.GroupTitle; } }
            private TableViewCalculator _table = new TableViewCalculator();
            private SearchField search;
            private Vector2 _scroll;
            private const string key = "Key";
            private const string lan = "Language";
            private const string value = "Value";
            private const string minnus = "minnus";
            private enum SearchType
            {
                Key, Language, Value
            }
            private SearchType _searchType;
            private string _search;
            private const float lineHeight = 20;
            public GroupView()
            {
                search = new SearchField("", Enum.GetNames(typeof(SearchType)), 0);
                search.onModeChange += (value) => { _searchType = (SearchType)value; };
                search.onValueChange += (value) => { _search = value; };
            }
            private ListViewCalculator.ColumnSetting[] setting
            {
                get
                {
                    return new ListViewCalculator.ColumnSetting[] {
                        new ListViewCalculator.ColumnSetting()
                        {
                            width=20,
                            name=minnus,

                        },
                         new ListViewCalculator.ColumnSetting()
                        {
                            width=100,
                            name=lan,
                        },
                        new ListViewCalculator.ColumnSetting()
                        {
                            width=createView.position.width-100,
                            name=key,
                        },
                          new ListViewCalculator.ColumnSetting()
                        {
                            width=100,
                            name=value,

                        }

                    };
                }
            }
            protected override void DrawContent(Rect rect)
            {
                var rs = rect.Zoom(AnchorType.MiddleCenter, -10).Split(SplitType.Horizontal, 30, 4);
                search.OnGUI(rs[0]);
                var ws = window._pairs.FindAll((w) => {
                    if (string.IsNullOrEmpty(_search))
                        return true;
                    switch (_searchType)
                    {
                        case SearchType.Key:
                            return w.key.ToLower().Contains(_search.ToLower());
                        case SearchType.Language:
                            return w.lan.ToString().ToLower().Contains(_search.ToLower());
                        case SearchType.Value:
                            return w.value.ToLower().Contains(_search.ToLower());
                    }
                    return true;
                }).ToArray();
                _table.Calc(rs[1], new Vector2(rs[1].x, rs[1].y + lineHeight), _scroll, lineHeight, ws.Length, setting);
                this.LabelField(_table.titleRow.position, "", Styles.Title)
                    .LabelField(_table.titleRow[key].position, key)
                    .LabelField(_table.titleRow[lan].position, lan)
                    .LabelField(_table.titleRow[value].position, value);
                Event e = Event.current;
                this.DrawScrollView(() => {

                    for (int i = _table.firstVisibleRow; i < _table.lastVisibleRow + 1; i++)
                    {
                        if (e.modifiers == EventModifiers.Control &&
                               e.button == 0 && e.clickCount == 1 &&
                               _table.rows[i].position.Contains(e.mousePosition))
                        {
                            _table.ControlSelectRow(i);
                            window.Repaint();
                        }
                        else if (e.modifiers == EventModifiers.Shift &&
                                        e.button == 0 && e.clickCount == 1 &&
                                        _table.rows[i].position.Contains(e.mousePosition))
                        {
                            _table.ShiftSelectRow(i);
                            window.Repaint();
                        }
                        else if (e.button == 0 && e.clickCount == 1 &&
                                        _table.rows[i].position.Contains(e.mousePosition)
                                      /*  && ListView.viewPosition.Contains(Event.current.mousePosition) */)
                        {
                            _table.SelectRow(i);
                            window.Repaint();
                        }
                        if (e.button == 0 && e.clickCount == 1 &&
              (!_table.view.Contains(e.mousePosition) ||
                  (_table.view.Contains(e.mousePosition) &&
                   !_table.content.Contains(e.mousePosition))))
                        {
                            _table.SelectNone();
                            window.Repaint();
                        }

                        if (e.button == 1 && e.clickCount == 1 &&
                        _table.content.Contains(e.mousePosition))
                        {
                            GenericMenu menu = new GenericMenu();
                            menu.AddItem(new GUIContent("Delete"), false, () => {
                                if (EditorUtility.DisplayDialog("Make Sure", string.Format("Really want delete {0} pairs", _table.rows.Count), "yes", "no"))
                                {
                                    for (int j = _table.rows.Count - 1; j >= 0; j--)
                                    {
                                        if (_table.rows[j].selected)
                                            window.DeleteLanPair(ws[j]);
                                    }
                                    window.UpdateLanGroup();
                                }
                            });

                            menu.ShowAsContext();
                            if (e.type != EventType.Layout)
                                e.Use();

                        }


                        GUIStyle style = i % 2 == 0 ? Styles.EntryBackEven : Styles.EntryBackodd;
                        if (Event.current.type == EventType.Repaint)
                            style.Draw(_table.rows[i].position, false, false, _table.rows[i].selected, false);

                        this.Pan(() => {
                            EditorGUI.EnumPopup(_table.rows[i][lan].position, ws[i].lan);
                        })
                        .Button(() => {
                            if (EditorUtility.DisplayDialog("Make Sure", string.Format("Really want delete\n" +
                                "Key :{0}\n" +
                                "Language :{1}\n" +
                                "Value : {2}", ws[i].key, ws[i].lan, ws[i].value), "yes", "no"))
                            {
                                window.DeleteLanPair(ws[i]);
                                window.UpdateLanGroup();
                            }

                        }, _table.rows[i][minnus].position, "", Styles.minus)
                             .SelectableLabel(_table.rows[i][key].position, ws[i].key)
                             .SelectableLabel(_table.rows[i][value].position, ws[i].value);
                    }
                }, _table.view, ref _scroll, _table.content, false, false);
                Handles.color = Color.black;
                for (int i = 0; i < _table.titleRow.columns.Count; i++)
                {
                    var item = _table.titleRow.columns[i];

                    if (i != 0)
                        Handles.DrawAAPolyLine(1, new Vector3(item.position.x,
                                                                item.position.y,
                                                                0),
                                                  new Vector3(item.position.x,
                                                                item.position.y + item.position.height - 2,
                                                                0));
                }
                _table.position.DrawOutLine(2, Color.black);
                Handles.color = Color.white;
            }
        }
    }
}