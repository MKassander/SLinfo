using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;

public class AttachVideo : MonoBehaviour
{
    private VideoPlayer VideoPlayer => GetComponent<VideoPlayer>();
    public string path;
    private bool hasPlayed = false;

    public void Awake()
    {
        VideoPlayer.url = Path.Combine(Application.streamingAssetsPath, path + ".mp4");
        VideoPlayer.loopPointReached += VideoPlayerOnloopPointReached;
    }

    private void VideoPlayerOnloopPointReached(VideoPlayer source)
    {
        hasPlayed = true;
    }

    private void FixedUpdate()
    {
        if (!VideoPlayer.isPlaying && !hasPlayed)
        {
            VideoPlayer.Play();
        }
    }
}
