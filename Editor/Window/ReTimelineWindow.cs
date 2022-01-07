using System;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

namespace ReTimeline.Editor
{
    [EditorWindowTitle(title = "ReTimeline", useTypeNameAsIconName = false)]
    public class ReTimelineWindow : EditorWindow, IHasCustomMenu
    {
        EditorGUIUtility.EditorLockTracker m_LockTracker = new EditorGUIUtility.EditorLockTracker();
        public bool locked
        {
            get { return m_LockTracker.isLocked; }
            set { m_LockTracker.isLocked = value; }
        }

        public static ReTimelineWindow instance { get; private set; }

        public ReTimelineWindow()
        {
            m_LockTracker.lockStateChanged.AddPersistentListener(OnLockStateChanged, UnityEventCallState.EditorAndRuntime);
        }

        void OnLockStateChanged(bool locked)
        {

        }

        protected virtual void ShowButton(Rect r)
        {
            m_LockTracker.ShowButton(r, DirectorStyles.Instance.lockButton, false);
        }

        public virtual void AddItemsToMenu(GenericMenu menu)
        {
            m_LockTracker.AddItemsToMenu(menu, false); 
        }

        private void OnEnable()
        {
            if (instance == null)
                instance = this;
        }

        private void OnGUI()
        {

        }

        [MenuItem("Window/Sequencing/ReTimeline", false, 2)]
        public static void ShowWindow()
        {
            GetWindow<ReTimelineWindow>(typeof(SceneView));
            instance.Focus();
        }

    }
}

