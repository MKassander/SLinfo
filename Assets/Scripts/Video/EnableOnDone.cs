using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EnableOnDone : MonoBehaviour
{
    private VideoPlayer VideoPlayer => GetComponent<VideoPlayer>();
    public GameObject StartCanvas;

    private void FixedUpdate()
    {
        if (VideoPlayer.time >= VideoPlayer.clip.length)
        {
            PauseAndEnable();
        }
    }

    void PauseAndEnable()
    {
        VideoPlayer.Pause();
        StartCanvas.SetActive(true);
    }
}
