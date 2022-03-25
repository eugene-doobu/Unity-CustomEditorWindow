#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace ListViewExample
{
    public class AddCallbacks : EditorWindow
    {
        private VisualElement _rightPane;

        [MenuItem("CustomWindow/ListView/AddCallbacks")]
        public static void ShowMyEditor2()
        {
            // This method is called when the user selects the menu item in the Editor
            var wnd = GetWindow<AddCallbacks>();
            wnd.titleContent = new GUIContent("AddCallbacks");
        }
    
        public void CreateGUI()
        {
            // Create a two-pane view with the left pane being fixed with
            var splitView = new TwoPaneSplitView(0, 250, TwoPaneSplitViewOrientation.Horizontal);

            // Add the view to the visual tree by adding it as a child to the root element
            rootVisualElement.Add(splitView);

            // A TwoPaneSplitView always needs exactly two child elements
            var leftPane = new ListView();
            splitView.Add(leftPane);
            _rightPane = new VisualElement();
            splitView.Add(_rightPane);

            var allObjects = new List<string>();
            allObjects.Add("test1");
            allObjects.Add("test2");
            allObjects.Add("test3");

            leftPane.makeItem = () => new Label();
            leftPane.bindItem = (item, index) => {(item as Label).text = allObjects[index]; };
            leftPane.itemsSource = allObjects;
        }
    }   
}
#endif
