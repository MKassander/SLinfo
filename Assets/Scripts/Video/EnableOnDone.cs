using UnityEngine;
using UnityEngine.Video;

public class EnableOnDone : MonoBehaviour
{
    private VideoPlayer VideoPlayer => GetComponent<VideoPlayer>();
    public GameObject StartCanvas;

    private void Start()
    {
        VideoPlayer.loopPointReached += VideoPlayerOnloopPointReached;
    }

    private void VideoPlayerOnloopPointReached(VideoPlayer source)
    {
        PauseAndEnable();
    }

    void PauseAndEnable()
    {
        VideoPlayer.Pause();
        StartCanvas.SetActive(true);
    }
}
