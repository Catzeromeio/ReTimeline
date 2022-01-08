using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReTimeline.Editor
{
    public class WindowState
    {
        readonly ReTimelineWindow m_Window;

        float m_SequencerHeaderWidth = WindowConstants.defaultHeaderWidth;

        public WindowState(ReTimelineWindow w)
        {
            m_Window = w;
        }

        public float sequencerHeaderWidth
        {
            get { return m_SequencerHeaderWidth; }
            set
            {
                m_SequencerHeaderWidth = Mathf.Clamp(value, WindowConstants.minHeaderWidth, WindowConstants.maxHeaderWidth);
            }
        }


        public Rect timeAreaRect
        {
            get
            {
                var sequenceContentRect = m_Window.sequenceContentRect;
                return new Rect(
                    sequenceContentRect.x,
                    WindowConstants.timeAreaYPosition,
                    Mathf.Max(sequenceContentRect.width, WindowConstants.timeAreaMinWidth),
                    WindowConstants.timeAreaHeight
                );
            }
        }
    }
}
