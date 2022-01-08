using UnityEditor;
using UnityEngine;

namespace ReTimeline.Editor
{
    partial class ReTimelineWindow
    {
        public TimelineTreeViewGUI treeView { get; private set; }


        float m_VerticalScrollBarSize, m_HorizontalScrollBarSize;

        public float verticalScrollbarWidth
        {
            get { return m_VerticalScrollBarSize; }
        }

        public float horizontalScrollbarHeight
        {
            get { return m_HorizontalScrollBarSize; }
        }


        public Rect sequenceContentRect
        {
            get
            {
                return new Rect(
                    state.sequencerHeaderWidth,
                    WindowConstants.markerRowYPosition,
                    position.width - state.sequencerHeaderWidth - (treeView != null && treeView.showingVerticalScrollBar ? WindowConstants.sliderWidth : 0),
                    position.height - WindowConstants.markerRowYPosition - horizontalScrollbarHeight);
            }
        }


        void DoLayout()
        {
            SequenceGUI();
        }

        void SequenceGUI()
        {
            DrawHeaderBackground();
        }

        void DrawHeaderBackground()
        {
            var rect = state.timeAreaRect;
            rect.xMin = 0.0f;
            EditorGUI.DrawRect(rect, DirectorStyles.Instance.customSkin.colorTimelineBackground);
        }

    }
}
