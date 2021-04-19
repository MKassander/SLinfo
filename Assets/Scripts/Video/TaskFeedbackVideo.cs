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

        public GameObject[] nextCanvas, currentCanvas;
        public TaskTracker taskTracker;

        private void Start()
        {
            VideoPlayer.loopPointReached += VideoPlayerOnloopPointReached;
            VideoPlayer.targetTexture.Release();
        }

        private void VideoPlayerOnloopPointReached(VideoPlayer source)
        {
            panel.SetActive(false);
            VideoPlayer.targetTexture.Release();

            //if (index == nextCanvas.Length + 1) return;
            //else
            nextCanvas[index].SetActive(true);
            if (index <= currentCanvas.Length) currentCanvas[index].SetActive(false);
            taskTracker.OnTaskDone();
            
            index++;
        }

        public void OnTaskDone()
        {
            panel.SetActive(true);
            VideoPlayer.url = Path.Combine(Application.streamingAssetsPath, videoClips[index] + ".mp4");
        }
    }
}
