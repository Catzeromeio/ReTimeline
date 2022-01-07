using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace ReTimeline.Editor
{
    public class DirectorStyles
    {
        public GUIStyle groupBackground;
        public GUIStyle displayBackground;
        public GUIStyle fontClip;
        public GUIStyle fontClipLoop;
        public GUIStyle trackHeaderFont;
        public GUIStyle trackGroupAddButton;
        public GUIStyle groupFont;
        public GUIStyle timeCursor;
        public GUIStyle endmarker;
        public GUIStyle tinyFont;
        public GUIStyle foldout;
        public GUIStyle mute;
        public GUIStyle locked;
        public GUIStyle autoKey;
        public GUIStyle playTimeRangeStart;
        public GUIStyle playTimeRangeEnd;
        public GUIStyle selectedStyle;
        public GUIStyle trackSwatchStyle;
        public GUIStyle connector;
        public GUIStyle keyframe;
        public GUIStyle warning;
        public GUIStyle extrapolationHold;
        public GUIStyle extrapolationLoop;
        public GUIStyle extrapolationPingPong;
        public GUIStyle extrapolationContinue;
        public GUIStyle collapseMarkers;
        public GUIStyle markerMultiOverlay;
        public GUIStyle bottomShadow;
        public GUIStyle trackOptions;
        public GUIStyle infiniteTrack;
        public GUIStyle clipOut;
        public GUIStyle clipIn;
        public GUIStyle curves;
        public GUIStyle lockedBG;
        public GUIStyle activation;
        public GUIStyle playrange;
        public GUIStyle lockButton;
        public GUIStyle avatarMaskOn;
        public GUIStyle avatarMaskOff;
        public GUIStyle markerWarning;
        public GUIStyle editModeBtn;
        public GUIStyle showMarkersBtn;
        public GUIStyle sequenceSwitcher;

        static internal DirectorStyles s_Instance;

        public static DirectorStyles Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new DirectorStyles();
                    s_Instance.Initialize();
                }

                return s_Instance;
            }
        }

        DirectorStyles()
        {
            LoadStyles();

        }

        public void Initialize()
        {

        }

        void LoadStyles()
        {
            endmarker = GetGUIStyle("Icon-Endmarker");
            groupBackground = GetGUIStyle("groupBackground");
            displayBackground = GetGUIStyle("sequenceClip");
            fontClip = GetGUIStyle("Font-Clip");
            trackHeaderFont = GetGUIStyle("sequenceTrackHeaderFont");
            trackGroupAddButton = GetGUIStyle("sequenceTrackGroupAddButton");
            groupFont = GetGUIStyle("sequenceGroupFont");
            timeCursor = GetGUIStyle("Icon-TimeCursor");
            tinyFont = GetGUIStyle("tinyFont");
            foldout = GetGUIStyle("Icon-Foldout");
            mute = GetGUIStyle("Icon-Mute");
            locked = GetGUIStyle("Icon-Locked");
            autoKey = GetGUIStyle("Icon-AutoKey");
            playTimeRangeStart = GetGUIStyle("Icon-PlayAreaStart");
            playTimeRangeEnd = GetGUIStyle("Icon-PlayAreaEnd");
            selectedStyle = GetGUIStyle("Color-Selected");
            trackSwatchStyle = GetGUIStyle("Icon-TrackHeaderSwatch");
            connector = GetGUIStyle("Icon-Connector");
            keyframe = GetGUIStyle("Icon-Keyframe");
            warning = GetGUIStyle("Icon-Warning");
            extrapolationHold = GetGUIStyle("Icon-ExtrapolationHold");
            extrapolationLoop = GetGUIStyle("Icon-ExtrapolationLoop");
            extrapolationPingPong = GetGUIStyle("Icon-ExtrapolationPingPong");
            extrapolationContinue = GetGUIStyle("Icon-ExtrapolationContinue");
            bottomShadow = GetGUIStyle("Icon-Shadow");
            trackOptions = GetGUIStyle("Icon-TrackOptions");
            infiniteTrack = GetGUIStyle("Icon-InfiniteTrack");
            clipOut = GetGUIStyle("Icon-ClipOut");
            clipIn = GetGUIStyle("Icon-ClipIn");
            curves = GetGUIStyle("Icon-Curves");
            lockedBG = GetGUIStyle("Icon-LockedBG");
            activation = GetGUIStyle("Icon-Activation");
            playrange = GetGUIStyle("Icon-Playrange");
            lockButton = GetGUIStyle("IN LockButton");
            avatarMaskOn = GetGUIStyle("Icon-AvatarMaskOn");
            avatarMaskOff = GetGUIStyle("Icon-AvatarMaskOff");
            collapseMarkers = GetGUIStyle("TrackCollapseMarkerButton");
            markerMultiOverlay = GetGUIStyle("MarkerMultiOverlay");
            editModeBtn = GetGUIStyle("editModeBtn");
            showMarkersBtn = GetGUIStyle("showMarkerBtn");
            markerWarning = GetGUIStyle("markerWarningOverlay");
            sequenceSwitcher = GetGUIStyle("sequenceSwitcher");
        }

        public static GUIStyle GetGUIStyle(string s)
        {
            return EditorStyles.FromUSS(s);
        }
    }

}

