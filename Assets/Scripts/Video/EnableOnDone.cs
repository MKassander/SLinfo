using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EnableOnDone : MonoBehaviour
{
    private VideoPlayer VideoPlayer => GetComponent<VideoPlayer>();
    public GameObject StartCanvas;

    private void Start()
    {
        Invoke(nameof(PauseAndEnable), (float) VideoPlayer.clip.length - 0.1f);
    }

    void PauseAndEnable()
    {
        VideoPlayer.Pause();
        StartCanvas.SetActive(true);
    }
}
