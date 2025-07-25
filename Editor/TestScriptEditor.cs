using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestScript))]
public class TestScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TestScript myTarget = (TestScript)target;
        myTarget.x = EditorGUILayout.TextField("Label", myTarget.x);
    }
}