using System;

#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;


namespace Base
{
    public class HelloEditorWindow : EditorWindow
    {
        private string _helloText = "Hello Editor Window";
        private bool _groupEnable = false;
        
        private bool _myBool = true;
        private float _myFloat = 1.234f;

        private string _hoverText = "Hover me";
        private bool _isHover = false;

        [MenuItem("CustomWindow/Base/HelloEditorWindow")]
        private static void Init()
        {
            var window = (HelloEditorWindow) GetWindow(typeof(HelloEditorWindow));
            window.Show();

            window.titleContent.text = "HelloEditorWindow!";
        }

        private void OnGUI()
        {
            EditorStyles.boldLabel.normal.textColor = Color.yellow;
            
            GUILayout.Space(10f);
            GUILayout.Label("Header Label", EditorStyles.boldLabel);
            _helloText = EditorGUILayout.TextField("Text Field", _helloText);
            
            GUILayout.Space(10f);
            GUILayout.Label("Optional Group", EditorStyles.boldLabel);
            _groupEnable = EditorGUILayout.BeginToggleGroup("Optional Settings", _groupEnable);
            {
                _myBool = EditorGUILayout.Toggle("Toggle", _myBool);
                _myFloat = EditorGUILayout.Slider("Slider", _myFloat, -10, 10);
            }
            EditorGUILayout.EndToggleGroup();
            
            GUILayout.Space(10f);
            GUILayout.Label("Mouse Hover Event", EditorStyles.boldLabel);
            _hoverText = EditorGUILayout.TextField("Hover Text", _hoverText);
            _isHover = GUILayoutUtility.GetLastRect().Contains(Event.current.mousePosition);
        }

        private void Update()
        {
            if(_isHover) Debug.Log("Hover Event!!");
        }
    }
}

#endif