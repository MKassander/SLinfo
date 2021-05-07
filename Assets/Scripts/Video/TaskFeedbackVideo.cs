using System;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

namespace Video
{
    public class TaskFeedbackVideo : MonoBehaviour
    {
        private SceneSwitcher SceneSwitcher => GetComponent<SceneSwitcher>();
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
            
            VideoPlayer.url = Path.Combine(Application.streamingAssetsPath, videoClips[index] + ".mp4");
            VideoPlayer.Prepare();
        }

        private void VideoPlayerOnloopPointReached(VideoPlayer source)
        {
            if (index == videoClips.Length -1)
                SceneSwitcher.SwitchScene();
            panel.SetActive(false);
            VideoPlayer.targetTexture.Release();
            
            nextCanvas[index].SetActive(true);
            if (index < currentCanvas.Length) currentCanvas[index].SetActive(false);//
            taskTracker.OnTaskDone();
            
            index++;
            //Debug.Log("index: " + index);
            if (index < videoClips.Length)
            {
                VideoPlayer.url = Path.Combine(Application.streamingAssetsPath, videoClips[index] + ".mp4");
                VideoPlayer.Prepare();
                VideoPlayer.Pause();
            }
        }

        public void OnTaskDone()
        {
            panel.SetActive(true);
            VideoPlayer.frame = 0;
            VideoPlayer.Play();
        }
    }
}
