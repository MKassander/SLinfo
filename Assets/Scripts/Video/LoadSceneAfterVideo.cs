using UnityEngine;
using UnityEngine.Video;

namespace Video
{
    public class LoadSceneAfterVideo : MonoBehaviour
    {
        private VideoPlayer VideoPlayer => GetComponent<VideoPlayer>();
        private SceneSwitcher SceneSwitcher => GetComponent<SceneSwitcher>();
        private void Start()
        {
            VideoPlayer.loopPointReached += VideoPlayerOnloopPointReached;
        }

        private void VideoPlayerOnloopPointReached(VideoPlayer source)
        {
            SceneSwitcher.SwitchScene();
        }

    }
}
