using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Video;

public class Fade : MonoBehaviour
{
    private Image image => GetComponent<Image>();
    private VideoClip clip 
        => FindObjectOfType<LoadSceneAfterVideo>().GetComponent<VideoPlayer>().clip;
    public float fadeDuration = 1;

    private float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= clip.length) 
            image.CrossFadeAlpha(255, fadeDuration, false);
    }
}
