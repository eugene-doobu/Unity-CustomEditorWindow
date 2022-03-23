#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Base
{
    // https://docs.unity3d.com/ScriptReference/GUILayout.Button.html
    public class WindowButton : EditorWindow
    {
        [MenuItem("CustomWindow/Base/WindowButton")]
        private static void Init()
        {
            var window = GetWindow<WindowButton>("Window Button");
            window.Show();
        }
        
        private void OnGUI()
        {
            if (GUILayout.Button("Log Button"))
            {
                Debug.Log("Hello Button!");
            }

            GUILayout.Button("Width-200", GUILayout.Width(200));
            GUILayout.Button("Height-50", GUILayout.Height(50));
            GUILayout.Button("ExpandWidth-false", GUILayout.ExpandWidth(false));
        }
    }
}

#endif