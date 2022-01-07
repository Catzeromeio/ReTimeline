using System;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;


[EditorWindowTitle(title = "ReTimeline", useTypeNameAsIconName = true)]
public class ReTimelineWindow : EditorWindow
{
    public static ReTimelineWindow instance { get; private set; }

    private void OnEnable()
    {
        if (instance == null)
            instance = this;
    }

    [MenuItem("Window/Sequencing/ReTimeline", false, 2)]
    public static void ShowWindow()
    {
        GetWindow<ReTimelineWindow>(typeof(SceneView));
        instance.Focus();
    }
}
