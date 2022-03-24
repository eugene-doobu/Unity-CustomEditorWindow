#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

namespace Advanced
{
    public class Colorizer : EditorWindow
    {
        private Color _color;

        [MenuItem("CustomWindow/Advanced/Colorizer")]
        private static void Init()
        {
            var window = GetWindow<Colorizer>("Colorizer");
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);
            _color = EditorGUILayout.ColorField("Color", _color);
            if (GUILayout.Button("Colorize!!"))
            {
                Colorize();
            }
        }

        private void Colorize()
        {
            foreach (var obj in Selection.gameObjects)
            {
                var renderer = obj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.sharedMaterial.color = _color;
                }
            }
        }
    }
}
#endif