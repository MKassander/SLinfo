using System;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

namespace Video
{
    public class TaskFeedbackVideo : MonoBehaviour
    {
        public VideoPlayer VideoPlayer;
        public GameObject panel;
        public string[] videoClips;
        private int index = 0;

        private void Start()
        {
            VideoPlayer.loopPointReached += VideoPlayerOnloopPointReached;
        }

        private void VideoPlayerOnloopPointReached(VideoPlayer source)
        {
            panel.SetActive(false);
        }

        public void OnTaskDone()
        {
            panel.SetActive(true);
            VideoPlayer.url = Path.Combine(Application.streamingAssetsPath, videoClips[index] + ".mp4");
            index++;
            //VideoPlayer.Play();
        }
    }
}