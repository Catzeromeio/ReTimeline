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
    public partial class ReTimelineWindow : EditorWindow, IHasCustomMenu
    {


        EditorGUIUtility.EditorLockTracker m_LockTracker = new EditorGUIUtility.EditorLockTracker();
        public bool locked
        {
            get { return m_LockTracker.isLocked; }
            set { m_LockTracker.isLocked = value; }
        }

        public static ReTimelineWindow instance { get; private set; }
        public WindowState state { get; private set; }
       

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


            if (state == null)
            {
                state = new WindowState(this);
            }
        }

        private void OnGUI()
        {
            InitializeGUIIfRequired();
            UpdateGUIConstants();

            DoLayout();
        }

        void InitializeGUIIfRequired()
        {
            if (treeView == null)
            {
                treeView = new TimelineTreeViewGUI(this, position);
            }
        }

        void UpdateGUIConstants()
        {
            m_HorizontalScrollBarSize =
                GUI.skin.horizontalScrollbar.fixedHeight + GUI.skin.horizontalScrollbar.margin.top;
            m_VerticalScrollBarSize = (treeView != null && treeView.showingVerticalScrollBar)
                ? GUI.skin.verticalScrollbar.fixedWidth + GUI.skin.verticalScrollbar.margin.left
                : 0;
        }

        [MenuItem("Window/Sequencing/ReTimeline", false, 2)]
        public static void ShowWindow()
        {
            GetWindow<ReTimelineWindow>(typeof(SceneView));
            instance.Focus();
        }

    }
}

