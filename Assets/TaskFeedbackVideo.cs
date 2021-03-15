using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TaskFeedbackVideo : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public GameObject panel;
    public VideoClip[] videoClips;
    private int index = 0;

    public void OnTaskDone()
    {
        //panel.SetActive(true);
        VideoPlayer.clip = videoClips[index];
        VideoPlayer.Play();
    }
}
