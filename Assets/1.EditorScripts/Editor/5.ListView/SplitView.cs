#if UNITY_EDITOR
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SplitView : EditorWindow
{
    [MenuItem("CustomWindow/ListView/SplitView")]
    public static void ShowMyEditor()
    {
        // This method is called when the user selects the menu item in the Editor
        var wnd = GetWindow<SplitView>();
        wnd.titleContent = new GUIContent("Split View");
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
        var rightPane = new VisualElement();
        splitView.Add(rightPane);

        var allObjects = new List<string>();
        allObjects.Add("test1");
        allObjects.Add("test2");
        allObjects.Add("test3");

        leftPane.makeItem = () => new Label();
        leftPane.bindItem = (item, index) => {(item as Label).text = allObjects[index]; };
        leftPane.itemsSource = allObjects;
    }
}
#endif
