using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ReTimeline.Editor
{
    public class TimelineTreeViewGUI
    {
        readonly ReTimelineWindow m_Window;
        public TimelineTreeViewGUI(ReTimelineWindow sequencerWindow, Rect rect)
        {
            m_Window = sequencerWindow;
        }

        public bool showingVerticalScrollBar
        {
            get { return false; }
        }
    }
}
