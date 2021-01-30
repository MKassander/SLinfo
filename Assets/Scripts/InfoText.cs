using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoText : MonoBehaviour
{
    private float timer;
    public float DownSeconds;
    public float UpAfterSeconds;
    public float DestroyAfterSeconds;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer < DownSeconds) transform.position += Vector3.down;
        if (timer > UpAfterSeconds) transform.position += Vector3.up;
        if (timer > DestroyAfterSeconds) Destroy(gameObject);
    }
}
